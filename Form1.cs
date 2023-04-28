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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //сотрудники
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new EmploeesForm();
            form.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new TurniketForm();
            form.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new reportForm();
            form.ShowDialog();
            this.Show();
        }
    }
}
