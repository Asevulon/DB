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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
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
    }
}
