using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DB
{

    public partial class reportForm : Form
    {
        public reportForm()
        {
            InitializeComponent();
        }
        string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asevu\\source\\repos\\DB\\Database1.mdf";

        public Dictionary<int, string> SourceData
        {
            set
            {
                ReportSource.DataSource = value.ToArray();
                ReportSource.DisplayMember = "Value";
            }
        }

        public int SourceId
        {
            get
            {
                return ((KeyValuePair<int, string>)ReportSource.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in ReportSource.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                ReportSource.SelectedIndex = idx;
            }
        }


        private void ReportSourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SourceType = "";
            if (ReportSourceType.SelectedItem.ToString() == "Отчет по цеху") SourceType = "Workshop";
            if (ReportSourceType.SelectedItem.ToString() == "Отчет по бригаде") SourceType = "Brigade";
            if (ReportSourceType.SelectedItem.ToString() == "Отчет по специальности") SourceType = "Post";

            string offerSQL = "SELECT * FROM [" + SourceType + "]";
            if (ReportSourceType.SelectedItem.ToString() == "Отчет по бригаде") offerSQL += "INNER JOIN [Workshop] ON [Brigade].[Id_workshop]=[Workshop].[Id]";

            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(offerSQL, connection);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);
            var dict = new Dictionary<int, string>();
            foreach (DataRow row in table_Order.Rows)
            {
                string str = row["name"].ToString();
                if (ReportSourceType.SelectedItem.ToString() == "Отчет по бригаде") str += " " + row["name1"].ToString();
                dict.Add((int)row["Id"], str);
            }
            SourceData = dict;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReportSource.Text == "") return;
            if (ReportSourceType.Text == "") return;
            if (ReportType.Text == "") return;

            if (ReportType.Text == "Отчет по работавшему количеству человек") OnGetEployeesNum();
            else OnGetHumanHours();
        }

        private void OnGetEployeesNum()
        {
            string offerSQL = "SELECT DISTINCT [in_out].[Id_employee] FROM [in_out] INNER JOIN [Employee] ON [in_out].[Id_employee] = [Employee].[Id] INNER JOIN [Brigade] ON [Employee].[Id_brigade] = [Brigade].[Id] INNER JOIN [Workshop] ON [Brigade].[Id_workshop]=[Workshop].[Id] INNER JOIN [Post] ON [Employee].Id_post = [Post].Id";
            if (ReportSourceType.SelectedItem.ToString() == "Отчет по специальности") offerSQL += " WHERE [Post].[name] LIKE '%" + ReportSource.Text + "%'";
            else offerSQL += " WHERE [Brigade].[name]+' '+[Workshop].[name] LIKE '%" + ReportSource.Text + "%'";

            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(offerSQL, connection);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);
            int count = table_Order.Rows.Count;
            MessageBox.Show("Всего работало: " + count, "Отчет по числу работников", MessageBoxButtons.OK);
        }
        private void OnGetHumanHours()
        {
            string offerSQL = "SELECT DISTINCT [in_out].[Id_employee] FROM [in_out]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(offerSQL, connection);

            //Создаем объект-таблицу
            DataTable table_Order = new DataTable();

            //Заполняем таблицу посредством адаптера
            aOrder.Fill(table_Order);

            float hours = 0;
            foreach (DataRow row in table_Order.Rows)
            {
                offerSQL = "SELECT * FROM [in_out] INNER JOIN [Employee] ON [in_out].[Id_employee] = [Employee].[Id] INNER JOIN [Brigade] ON [Employee].[Id_brigade] = [Brigade].[Id] INNER JOIN [Workshop] ON [Brigade].[Id_workshop]=[Workshop].[Id] INNER JOIN [Post] ON [Employee].Id_post = [Post].Id";
                if (ReportSourceType.SelectedItem.ToString() == "Отчет по специальности") offerSQL += " WHERE [Post].[name] LIKE '%" + ReportSource.Text + "%'";
                else offerSQL += " WHERE [Brigade].[name]+' '+[Workshop].[name] LIKE '%" + ReportSource.Text + "%'";
                offerSQL += "AND [in_out].[Id_employee] LIKE '%" + (int)row["Id_employee"] + "%'";

                //Создаем объект адаптера
                SqlDataAdapter tOrder = new SqlDataAdapter(offerSQL, connection);

                //Создаем объект-таблицу
                DataTable Ttable_Order = new DataTable();

                //Заполняем таблицу посредством адаптера
                tOrder.Fill(Ttable_Order);

                //true - enter, false - exit
                bool whatfind = true;
                DateTime extime = DateTime.Now;
                DateTime entime = DateTime.Now;

                foreach (DataRow trow in Ttable_Order.Rows)
                {
                    if(whatfind)
                    {
                        if (trow["passage_status"].ToString() == "Exit")
                        {
                            extime = (DateTime)trow["time"];
                            continue;
                        }
                        entime = (DateTime)trow["time"];//dd.MM.yyyy HH:mm:ss
                        whatfind = false;

                    }
                    else
                    {
                        if (trow["passage_status"].ToString() == "Enter")
                        {
                            entime = (DateTime)trow["time"];//dd.MM.yyyy HH:mm:ss

                            continue;
                        }
                        extime = (DateTime)trow["time"];
                        var Substr = extime.Subtract(entime);
                        hours += Substr.Days * 24 + Substr.Hours + (float)Substr.Minutes / (float)60 + (float)Substr.Seconds / (float)3600;
                        whatfind = true;

                    }
                }
            }
            var str = string.Format("Отработано человеко-часов: {0:f1}", hours);
            MessageBox.Show( str, "Отчет по человеко-часам", MessageBoxButtons.OK);

        }
    }
}
