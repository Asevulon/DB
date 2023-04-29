using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class TurniketForm : Form
    {
        public TurniketForm()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM.dd.yyyy HH:mm:ss";
            
        }
        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asevu\\source\\repos\\DB\\Database1.mdf";

        private void TurniketForm_Load(object sender, EventArgs e)
        {
            

            LoadTable(TBnum.Text, TBfio.Text, TBWS.Text, TBState.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));
        }
        private void LoadTable(string num, string fio, string ws, string state, string time)
        {
            string offerSQL = "SELECT * FROM [in_out] INNER JOIN [Employee] ON [in_out].[Id_employee] = [Employee].[Id] INNER JOIN [Brigade] ON [Employee].[Id_brigade] = [Brigade].[Id] INNER JOIN [Workshop] ON [Brigade].[Id_workshop]=[Workshop].[Id]";
            offerSQL += " WHERE [Employee].[Id] LIKE '%" + num + "%'";
            offerSQL +=" AND [Employee].surname +' '+[Employee].name +''+[Employee].patronymic LIKE '%"+fio+ "%'";
            offerSQL += " AND [Workshop].[name] LIKE '%" + ws + "%'";
            offerSQL += " AND [in_out].[passage_status] LIKE '%" + state + "%'";
            if (CBtime.Checked) offerSQL += " AND [in_out].[time] LIKE '%" + time + "%'";
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(offerSQL, connection);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);

            dataGridView1.DataSource = table_Order;

            dataGridView1.Columns["Id_employee"].Visible = false;
            dataGridView1.Columns["Id_workshop"].Visible = false;
            dataGridView1.Columns["time"].HeaderText = "Время";
            dataGridView1.Columns["time"].DefaultCellStyle.Format = "MM.dd.yyyy HH:mm:ss";

            dataGridView1.Columns["passage_status"].HeaderText = "Вход/выход";
            dataGridView1.Columns["Id1"].HeaderText = "Табельный номер";
            dataGridView1.Columns["surname"].HeaderText = "Фамилия";
            dataGridView1.Columns["name"].HeaderText = "Имя";
            dataGridView1.Columns["patronymic"].HeaderText = "Отчество";
            dataGridView1.Columns["dateOfEmployment"].Visible = false;
            dataGridView1.Columns["Id_brigade"].Visible = false;
            dataGridView1.Columns["Id_post"].Visible = false;
            dataGridView1.Columns["Id3"].Visible = false;
            dataGridView1.Columns["name1"].Visible = false;
            dataGridView1.Columns["Id2"].Visible = false;
            dataGridView1.Columns["name2"].HeaderText = "Цех";
            dataGridView1.Columns["Id"].Visible = false;





            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string offerSQL = "SELECT * FROM [Employee]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(offerSQL, connection);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);
            var dict = new Dictionary<int, string>();
            foreach (DataRow row in table_Order.Rows)
            {
                dict.Add((int)row["Id"], row["surname"].ToString()+" " + row["name"]+" " + row["patronymic"]);
            }


            var form = new AddTurniketForm();
            form.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            form.dateTimePicker1.CustomFormat = "MM.dd.yyyy HH:mm:ss";
            form.Status = "Enter";
            form.EmployeeData = dict;
            var res = form.ShowDialog();
            if (res == DialogResult.Cancel) return;

            string status = form.Status;
            var id = form.EmployeeId;
            var time = form.dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"); 
            offerSQL = "INSERT INTO [in_out] (Id_employee, time, passage_status) VALUES ('" + id + "', '" + time + "', '" + status + "')";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connection;

            conn.Open();//Открываем соединение

            //Создаем команду, ассоциированную с открытым соединением
            SqlCommand comanding = conn.CreateCommand();

            //Определяем саму команду и ее параметры
            comanding.CommandText = offerSQL;

            //Выдаем команду, рез. команды помещаем в специальный объект
            SqlDataReader result = comanding.ExecuteReader();

            conn.Close();   //Закрываем соединение

            LoadTable(TBnum.Text, TBfio.Text, TBWS.Text, TBState.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows.Count;
            if (index == 0)
            {
                MessageBox.Show("Выделите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var srow = dataGridView1.SelectedRows[0];

            string offerSQL = "SELECT * FROM [Employee]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(offerSQL, connection);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);
            var dict = new Dictionary<int, string>();
            foreach (DataRow row in table_Order.Rows)
            {
                dict.Add((int)row["Id"], row["surname"].ToString() + " " + row["name"] + " " + row["patronymic"]);
            }


            var form = new AddTurniketForm();
            form.buttonOK.Text = "Изменить";
            form.Status = srow.Cells["passage_status"].Value.ToString();
            form.EmployeeData = dict;
            form.EmployeeId = (int)srow.Cells["Id_employee"].Value;
            form.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            form.dateTimePicker1.CustomFormat = "MM.dd.yyyy HH:mm:ss";
            form.dateTimePicker1.Text = srow.Cells["time"].Value.ToString();
            var res = form.ShowDialog();
            if (res == DialogResult.Cancel) return;

            string status = form.Status;
            var id = form.EmployeeId;
            var time = form.dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

            offerSQL = "UPDATE [in_out] SET Id_employee = '" + id + "', time = '" + time + "', passage_status = '" + status + "' WHERE [in_out].[Id] = '" + srow.Cells["Id"].Value.ToString() + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connection;

            conn.Open();//Открываем соединение

            //Создаем команду, ассоциированную с открытым соединением
            SqlCommand comanding = conn.CreateCommand();

            //Определяем саму команду и ее параметры
            comanding.CommandText = offerSQL;

            //Выдаем команду, рез. команды помещаем в специальный объект
            SqlDataReader result = comanding.ExecuteReader();

            conn.Close();   //Закрываем соединение

            LoadTable(TBnum.Text, TBfio.Text, TBWS.Text, TBState.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows.Count;
            if (index == 0)
            {
                MessageBox.Show("Выделите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var srow = dataGridView1.SelectedRows[0];

            string offerSQL = "DELETE FROM [in_out] WHERE [in_out].[Id] = '" + srow.Cells["Id"].Value.ToString() + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connection;

            conn.Open();//Открываем соединение

            //Создаем команду, ассоциированную с открытым соединением
            SqlCommand comanding = conn.CreateCommand();

            //Определяем саму команду и ее параметры
            comanding.CommandText = offerSQL;

            //Выдаем команду, рез. команды помещаем в специальный объект
            SqlDataReader result = comanding.ExecuteReader();

            conn.Close();   //Закрываем соединение

            LoadTable(TBnum.Text, TBfio.Text, TBWS.Text, TBState.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));

        }

        private void TBnum_TextChanged(object sender, EventArgs e)
        {
            LoadTable(TBnum.Text, TBfio.Text, TBWS.Text, TBState.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));

        }

        private void TBfio_TextChanged(object sender, EventArgs e)
        {
            LoadTable(TBnum.Text, TBfio.Text, TBWS.Text, TBState.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));

        }

        private void TBWS_TextChanged(object sender, EventArgs e)
        {
            LoadTable(TBnum.Text, TBfio.Text, TBWS.Text, TBState.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));

        }

        private void TBState_TextChanged(object sender, EventArgs e)
        {
            LoadTable(TBnum.Text, TBfio.Text, TBWS.Text, TBState.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadTable(TBnum.Text, TBfio.Text, TBWS.Text, TBState.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));

        }

        private void CBtime_CheckedChanged(object sender, EventArgs e)
        {
            LoadTable(TBnum.Text, TBfio.Text, TBWS.Text, TBState.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));

        }
    }
}
