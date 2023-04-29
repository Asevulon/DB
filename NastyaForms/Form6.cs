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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            Update_workshop();
        }

        string together = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\79159\\Desktop\\ННГУ\\УД\\Новая папка\\Database1.mdf\";Integrated Security=True;Connect Timeout=30";

        private void Update_workshop()
        {
            string zaprSQL = "SELECT * FROM [Workshop]";

            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(zaprSQL, together);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);

            table_workshop.DataSource = table_Order;

            table_workshop.Columns["Id"].Visible = false;

            table_workshop.Columns["name"].HeaderText = "Цех";

            table_workshop.AutoResizeColumns();
            table_workshop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void add_workshop_Click(object sender, EventArgs e)
        {
            Form7 newfrm = new Form7();
            DialogResult res = newfrm.ShowDialog();
            if (res == DialogResult.OK)
            {
                string str_sur = newfrm.name_workshop.Text;
                string zaprSQL = "INSERT INTO [Workshop] (name) ";
                zaprSQL += "VALUES ('" + str_sur + "')";

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

                Update_workshop();
            }
        }

        private void change_workshop_Click(object sender, EventArgs e)
        {
            int index = table_workshop.SelectedRows.Count;
            if (index == 0)
            {
                MessageBox.Show("Выделите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var row = table_workshop.SelectedRows[0];
            Form7 newfrm = new Form7();
            newfrm.name_workshop.Text = row.Cells["name"].Value.ToString();
            DialogResult res = newfrm.ShowDialog();

            if (res == DialogResult.OK)
            {
                string str_sur = newfrm.name_workshop.Text;
                string zaprSQL = "UPDATE [Workshop] ";
                zaprSQL += "SET name='" + str_sur + "'";
                zaprSQL += "WHERE [Workshop].Id='" + row.Cells["Id"].Value.ToString() + "'";

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

                Update_workshop();
            }
        }

        private void delete_workshop_Click(object sender, EventArgs e)
        {
            int index = table_workshop.SelectedRows.Count;
            if (index == 0)
            {
                MessageBox.Show("Выделите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var row = table_workshop.SelectedRows[0];

            string zaprSQL = "DELETE FROM [Workshop] ";
            zaprSQL += "WHERE [Workshop].Id='" + row.Cells["Id"].Value.ToString() + "'";

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

            Update_workshop();
        }
    }
}
