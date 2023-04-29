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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Dictionary<int, string> WorkshopData
        {
            set
            {
                Workshops.DataSource = value.ToArray();
                Workshops.DisplayMember = "Value";
            }
        }

        public int WorkshopId
        {
            get
            {
                return ((KeyValuePair<int, string>)Workshops.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in Workshops.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                Workshops.SelectedIndex = idx;
            }
        }
    }
}
