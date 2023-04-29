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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Update_Brigada();
        }

        string together = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asevu\\source\\repos\\DB\\Database1.mdf";
        private void Update_Brigada()
        {
            string zaprSQL = "SELECT * FROM [Brigade] INNER JOIN [Workshop] ON [Brigade].Id_workshop = [Workshop].Id";

            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(zaprSQL, together);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);

            table_brigada.DataSource = table_Order;

            table_brigada.Columns["Id"].Visible = false;
            table_brigada.Columns["Id_workshop"].Visible = false;
            table_brigada.Columns["Id1"].Visible = false;

            table_brigada.Columns["name"].HeaderText = "Бригада";
            table_brigada.Columns["name1"].HeaderText = "Цех";

            table_brigada.AutoResizeColumns();
            table_brigada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void add_brigada_Click(object sender, EventArgs e)
        {
            string zapr = "SELECT * FROM [Workshop]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(zapr, together);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);
            var dict = new Dictionary<int, string>();
            foreach (DataRow row in table_Order.Rows)
            {
                dict.Add((int)row["Id"], row["name"].ToString());
            }

            Form5 newfrm = new Form5();
            newfrm.WorkshopData = dict;
            DialogResult res = newfrm.ShowDialog();
            if (res == DialogResult.OK)
            {
                string str_sur = newfrm.name_brigada.Text;
                var buffer = newfrm.WorkshopId;
                string zaprSQL = "INSERT INTO [Brigade] (name, Id_workshop) ";
                zaprSQL += "VALUES ('" + str_sur + "', '" + buffer + "')";

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = together;

                conn.Open();//Открываем соединение

                //Создаем команду, ассоциированную с открытым соединением
                SqlCommand comanding = conn.CreateCommand();

                //Определяем саму команду и ее параметры
                comanding.CommandText = zaprSQL;

                //Выдаем команду, рез. команды помещаем в специальный объект
                SqlDataReader result = comanding.ExecuteReader();

                conn.Close();	//Закрываем соединение

                Update_Brigada();
            }
        }

        private void change_brigada_Click(object sender, EventArgs e)
        {
            int index = table_brigada.SelectedRows.Count;
            if (index == 0)
            {
                MessageBox.Show("Выделите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var row_contact = table_brigada.SelectedRows[0];

            string zapr = "SELECT * FROM [Workshop]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(zapr, together);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);
            var dict = new Dictionary<int, string>();
            foreach (DataRow row in table_Order.Rows)
            {
                dict.Add((int)row["Id"], row["name"].ToString());
            }

            Form5 newfrm = new Form5();
            newfrm.WorkshopData = dict;
            newfrm.name_brigada.Text = row_contact.Cells["name"].Value.ToString();
            DialogResult res = newfrm.ShowDialog();
            if (res == DialogResult.OK)
            {
                string str_num = newfrm.name_brigada.Text;
                var buffer = newfrm.WorkshopId;
                string zaprSQL = "UPDATE [Brigade] ";
                zaprSQL += "SET name='" + str_num + "', Id_workshop='" + buffer + "'";
                zaprSQL += "WHERE [Brigade].Id='" + row_contact.Cells["Id"].Value.ToString() + "'";

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = together;

                conn.Open();//Открываем соединение

                //Создаем команду, ассоциированную с открытым соединением
                SqlCommand comanding = conn.CreateCommand();

                //Определяем саму команду и ее параметры
                comanding.CommandText = zaprSQL;

                //Выдаем команду, рез. команды помещаем в специальный объект
                SqlDataReader result = comanding.ExecuteReader();

                conn.Close();	//Закрываем соединение

                Update_Brigada();
            }
        }

        private void delete_brigada_Click(object sender, EventArgs e)
        {
            int index = table_brigada.SelectedRows.Count;
            if (index == 0)
            {
                MessageBox.Show("Выделите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var row = table_brigada.SelectedRows[0];

            string zaprSQL = "DELETE FROM [Brigade] ";
            zaprSQL += "WHERE [Brigade].Id='" + row.Cells["Id"].Value.ToString() + "'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = together;

            conn.Open();//Открываем соединение

            //Создаем команду, ассоциированную с открытым соединением
            SqlCommand comanding = conn.CreateCommand();

            //Определяем саму команду и ее параметры
            comanding.CommandText = zaprSQL;

            //Выдаем команду, рез. команды помещаем в специальный объект
            SqlDataReader result = comanding.ExecuteReader();

            conn.Close();	//Закрываем соединение

            Update_Brigada();
        }
    }
}
