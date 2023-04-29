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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            Update_post();
        }

        string together = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\79159\\Desktop\\ННГУ\\УД\\Новая папка\\Database1.mdf\";Integrated Security=True;Connect Timeout=30";
       
        private void Update_post()
        {
            string zaprSQL = "SELECT * FROM [Post]";

            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(zaprSQL, together);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);

            table_post.DataSource = table_Order;

            table_post.Columns["Id"].Visible = false;

            table_post.Columns["name"].HeaderText = "Должность";

            table_post.AutoResizeColumns();
            table_post.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void add_post_Click(object sender, EventArgs e)
        {
            Form9 newfrm = new Form9();
            DialogResult res = newfrm.ShowDialog();
            if (res == DialogResult.OK)
            {
                string str_sur = newfrm.name_post.Text;
                string zaprSQL = "INSERT INTO [Post] (name) ";
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

                Update_post();
            }
        }

        private void change_post_Click(object sender, EventArgs e)
        {
            int index = table_post.SelectedRows.Count;
            if (index == 0)
            {
                MessageBox.Show("Выделите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var row = table_post.SelectedRows[0];
            Form9 newfrm = new Form9();
            newfrm.name_post.Text = row.Cells["name"].Value.ToString();
            DialogResult res = newfrm.ShowDialog();

            if (res == DialogResult.OK)
            {
                string str_sur = newfrm.name_post.Text;
                string zaprSQL = "UPDATE [Post] ";
                zaprSQL += "SET name='" + str_sur + "'";
                zaprSQL += "WHERE [Post].Id='" + row.Cells["Id"].Value.ToString() + "'";

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

                Update_post();
            }
        }

        private void delete_post_Click(object sender, EventArgs e)
        {
            int index = table_post.SelectedRows.Count;
            if (index == 0)
            {
                MessageBox.Show("Выделите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var row = table_post.SelectedRows[0];

            string zaprSQL = "DELETE FROM [Post] ";
            zaprSQL += "WHERE [Post].Id='" + row.Cells["Id"].Value.ToString() + "'";

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

            Update_post();
        }
    }
}
