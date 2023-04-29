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
    public partial class EmploeesForm : Form
    {
        public EmploeesForm()
        {
            InitializeComponent();
            CreateListBrig();
            CreateListPost();
            Update_empl("");
            data_on_work.Format = DateTimePickerFormat.Custom;
            data_on_work.CustomFormat = "dd.MM.yyyy HH:mm:ss";
        }

        string together = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\asevu\\OneDrive\\Рабочий стол\\Новая папка\\Database1.mdf\";Integrated Security=True;Connect Timeout=30";
        private void Update_empl(string str)
        {
            string zaprSQL = "SELECT * FROM [Employee] INNER JOIN [Brigade] ON [Employee].Id_brigade = [Brigade].Id ";
            zaprSQL += "INNER JOIN [Workshop] ON [Brigade].Id_workshop = [Workshop].Id ";
            zaprSQL += "INNER JOIN [Post] ON [Employee].Id_post = [Post].Id ";
            zaprSQL += str;

            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(zaprSQL, together);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);

            Employees.DataSource = table_Order;

            Employees.Columns["Id_brigade"].Visible = false;
            Employees.Columns["Id_post"].Visible = false;
            Employees.Columns["Id_workshop"].Visible = false;
            Employees.Columns["Id1"].Visible = false;
            Employees.Columns["Id2"].Visible = false;
            Employees.Columns["Id3"].Visible = false;

            Employees.Columns["Id"].HeaderText = "Табельный номер";
            Employees.Columns["surname"].HeaderText = "Фамилия";
            Employees.Columns["name"].HeaderText = "Имя";
            Employees.Columns["name1"].HeaderText = "Бригада";
            Employees.Columns["name2"].HeaderText = "Цех";
            Employees.Columns["name3"].HeaderText = "Должность";
            Employees.Columns["patronymic"].HeaderText = "Отчество";
            Employees.Columns["dateOfEmployment"].HeaderText = "Дата приема на работу";
            Employees.Columns["dateOfEmployment"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";

            Employees.AutoResizeColumns();
            Employees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void add_emp_Click(object sender, EventArgs e)
        {
            string zapr = "SELECT * FROM [Workshop]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder_workshop = new SqlDataAdapter(zapr, together);

            //Создаем объект-таблицу
            DataTable table_Order_workshop = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder_workshop.Fill(table_Order_workshop);
            var dict_workshop = new Dictionary<int, string>();
            foreach (DataRow row in table_Order_workshop.Rows)
            {
                dict_workshop.Add((int)row["Id"], row["name"].ToString());
            }

            zapr = "SELECT * FROM [Brigade]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(zapr, together);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);
            var dict_brigade = new Dictionary<int, string>();
            foreach (DataRow row in table_Order.Rows)
            {
                dict_brigade.Add((int)row["Id"], row["name"].ToString() + " " + dict_workshop[(int)row["Id_workshop"]]);
            }

            zapr = "SELECT * FROM [Post]";
            //Создаем объект адаптера
            aOrder = new SqlDataAdapter(zapr, together);

            //Создаем объект-таблицу
            table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);
            var dict_post = new Dictionary<int, string>();
            foreach (DataRow row in table_Order.Rows)
            {
                dict_post.Add((int)row["Id"], row["name"].ToString());
            }

            Form3 newfrm = new Form3();
            newfrm.BrigadaData = dict_brigade;
            newfrm.PostData = dict_post;
            DialogResult res = newfrm.ShowDialog();
            if (res == DialogResult.OK)
            {
                string str_sur = newfrm.surname_emp.Text;
                string str_name = newfrm.name_emp.Text;
                string str_patronimyc = newfrm.patronimyc_emp.Text;
                var time_of_emp = newfrm.data_of_employment.Value.ToString("yyyy'-'MM'-'dd");
                var buffer_brigada = newfrm.BrigadaId;
                var buffer_post = newfrm.PostId;
                string zaprSQL = "INSERT INTO [Employee] (surname, name, patronymic, dateOfEmployment, Id_brigade, Id_post) ";
                zaprSQL += "VALUES ('" + str_sur + "', '" + str_name + "', '" + str_patronimyc + "', '" + time_of_emp + "', '" + buffer_brigada + "', '" + buffer_post + "')";

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

                Update_empl("");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm = new Form4();
            frm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm = new Form6();
            frm.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 frm = new Form8();
            frm.ShowDialog();
            this.Show();
        }

        private void change_emp_Click(object sender, EventArgs e)
        {
            int index = Employees.SelectedRows.Count;
            if (index == 0)
            {
                MessageBox.Show("Выделите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var row_contact = Employees.SelectedRows[0];

            string zapr = "SELECT * FROM [Workshop]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder_workshop = new SqlDataAdapter(zapr, together);

            //Создаем объект-таблицу
            DataTable table_Order_workshop = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder_workshop.Fill(table_Order_workshop);
            var dict_workshop = new Dictionary<int, string>();
            foreach (DataRow row in table_Order_workshop.Rows)
            {
                dict_workshop.Add((int)row["Id"], row["name"].ToString());
            }

            zapr = "SELECT * FROM [Brigade]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(zapr, together);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);
            var dict_brigade = new Dictionary<int, string>();
            foreach (DataRow row in table_Order.Rows)
            {
                dict_brigade.Add((int)row["Id"], row["name"].ToString() + " " + dict_workshop[(int)row["Id_workshop"]]);
            }

            zapr = "SELECT * FROM [Post]";
            //Создаем объект адаптера
            aOrder = new SqlDataAdapter(zapr, together);

            //Создаем объект-таблицу
            table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);
            var dict_post = new Dictionary<int, string>();
            foreach (DataRow row in table_Order.Rows)
            {
                dict_post.Add((int)row["Id"], row["name"].ToString());
            }

            Form3 newfrm = new Form3();
            newfrm.BrigadaData = dict_brigade;
            newfrm.PostData = dict_post;
            newfrm.surname_emp.Text = row_contact.Cells["surname"].Value.ToString();
            newfrm.name_emp.Text = row_contact.Cells["name"].Value.ToString();
            newfrm.patronimyc_emp.Text = row_contact.Cells["patronymic"].Value.ToString();
            newfrm.data_of_employment.Text = row_contact.Cells["dateOfEmployment"].Value.ToString();
            DialogResult res = newfrm.ShowDialog();
            if (res == DialogResult.OK)
            {
                string str_sur = newfrm.surname_emp.Text;
                string str_name = newfrm.name_emp.Text;
                string str_patronimyc = newfrm.patronimyc_emp.Text;
                var time_of_emp = newfrm.data_of_employment.Value.ToString("yyyy'-'MM'-'dd");
                var buffer_brigada = newfrm.BrigadaId;
                var buffer_post = newfrm.PostId;
                string zaprSQL = "UPDATE [Employee] ";
                zaprSQL += "SET surname='" + str_sur + "', name='" + str_name + "', patronymic='" + str_patronimyc + "', dateOfEmployment='" + time_of_emp + "', Id_brigade='" + buffer_brigada + "', Id_post='" + buffer_post + "'";
                zaprSQL += "WHERE [Employee].Id='" + row_contact.Cells["Id"].Value.ToString() + "'";

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

                Update_empl("");
            }
        }

        private void delete_emp_Click(object sender, EventArgs e)
        {
            int index = Employees.SelectedRows.Count;
            if (index == 0)
            {
                MessageBox.Show("Выделите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var row = Employees.SelectedRows[0];

            string zaprSQL = "DELETE FROM [Employee] ";
            zaprSQL += "WHERE [Employee].Id='" + row.Cells["Id"].Value.ToString() + "'";

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

            Update_empl("");
        }

        private void FIO_TextChanged(object sender, EventArgs e)
        {
            string str = "WHERE [Employee].surname +' '+[Employee].name +'";
            str += "'+[Employee].patronymic LIKE ";
            str += "'%";
            str += FIO.Text;
            str += "%'";
            Update_empl(str);
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            string str = "WHERE [Employee].Id LIKE ";
            str += "'%";
            str += id.Text;
            str += "%'";
            Update_empl(str);
        }

        public Dictionary<int, string> BrigadaData
        {
            set
            {
                list_brigada.DataSource = value.ToArray();
                list_brigada.DisplayMember = "Value";
            }
        }

        public int BrigadaId
        {
            get
            {
                return ((KeyValuePair<int, string>)list_brigada.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in list_brigada.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                list_brigada.SelectedIndex = idx;
            }
        }

        public Dictionary<int, string> PostData
        {
            set
            {
                list_post.DataSource = value.ToArray();
                list_post.DisplayMember = "Value";
            }
        }

        public int PostId
        {
            get
            {
                return ((KeyValuePair<int, string>)list_post.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in list_post.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                list_post.SelectedIndex = idx;
            }
        }

        private void CreateListBrig()
        {
            string zapr = "SELECT * FROM [Workshop]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder_workshop = new SqlDataAdapter(zapr, together);

            //Создаем объект-таблицу
            DataTable table_Order_workshop = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder_workshop.Fill(table_Order_workshop);
            var dict_workshop = new Dictionary<int, string>();
            foreach (DataRow row in table_Order_workshop.Rows)
            {
                dict_workshop.Add((int)row["Id"], row["name"].ToString());
            }

            zapr = "SELECT * FROM [Brigade]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(zapr, together);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);
            var dict_brigade = new Dictionary<int, string>();
            dict_brigade.Add(0, "all");
            foreach (DataRow row in table_Order.Rows)
            {
                dict_brigade.Add((int)row["Id"], row["name"].ToString() + " " + dict_workshop[(int)row["Id_workshop"]]);
            }

            BrigadaData = dict_brigade;
        }

        private void list_brigada_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "WHERE [Employee].Id_brigade LIKE ";
            str += "'%";
            if (BrigadaId != 0) str += BrigadaId;
            str += "%'";
            Update_empl(str);
        }

        private void CreateListPost()
        {
            string zapr = "SELECT * FROM [Post]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(zapr, together);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);
            var dict_brigade = new Dictionary<int, string>();
            dict_brigade.Add(0, "all");
            foreach (DataRow row in table_Order.Rows)
            {
                dict_brigade.Add((int)row["Id"], row["name"].ToString());
            }

            PostData = dict_brigade;
        }

        private void list_post_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "WHERE [Employee].Id_post LIKE ";
            str += "'%";
            if (PostId != 0) str += PostId;
            str += "%'";
            Update_empl(str);
        }

        private void data_on_work_TextChanged(object sender, EventArgs e)
        {
            string str = "WHERE [Employee].dateOfEmployment LIKE ";
            str += "'%";
            str += data_on_work.Text;
            str += "%'";
            Update_empl(str);
        }

        private void clear_filter_Click(object sender, EventArgs e)
        {
            Update_empl("");
        }

        private void data_on_work_ValueChanged(object sender, EventArgs e)
        {
            string str = "WHERE [Employee].dateOfEmployment LIKE ";
            str += "'%";
            str += data_on_work.Value.ToString("yyyy'-'MM'-'dd");
            str += "%'";
            Update_empl(str);
        }
    }
}
