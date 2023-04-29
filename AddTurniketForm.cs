using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class AddTurniketForm : Form
    {
        public AddTurniketForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK; 
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        public Dictionary<int, string> EmployeeData
        {
            set
            {
                comboBox1.DataSource = value.ToArray();
                comboBox1.DisplayMember = "Value";
            }
        }

        public int EmployeeId
        {
            get
            {
                return ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in comboBox1.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                comboBox1.SelectedIndex = idx;
            }
        }


        

        public string Status
        {
            get
            {
                return comboBox2.SelectedItem.ToString();
            }
            set
            {
                if (value == "Enter") comboBox2.SelectedIndex = 0;
                if (value == "Exit") comboBox2.SelectedIndex = 1;
            }
        }
    }
}
