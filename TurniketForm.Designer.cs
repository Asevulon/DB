namespace DB
{
    partial class TurniketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TBnum = new System.Windows.Forms.TextBox();
            this.TBfio = new System.Windows.Forms.TextBox();
            this.TBWS = new System.Windows.Forms.TextBox();
            this.TBState = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CBtime = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(94, 415);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TBnum
            // 
            this.TBnum.Location = new System.Drawing.Point(360, 446);
            this.TBnum.Name = "TBnum";
            this.TBnum.Size = new System.Drawing.Size(100, 20);
            this.TBnum.TabIndex = 4;
            this.TBnum.TextChanged += new System.EventHandler(this.TBnum_TextChanged);
            // 
            // TBfio
            // 
            this.TBfio.Location = new System.Drawing.Point(466, 446);
            this.TBfio.Name = "TBfio";
            this.TBfio.Size = new System.Drawing.Size(100, 20);
            this.TBfio.TabIndex = 5;
            this.TBfio.TextChanged += new System.EventHandler(this.TBfio_TextChanged);
            // 
            // TBWS
            // 
            this.TBWS.Location = new System.Drawing.Point(572, 446);
            this.TBWS.Name = "TBWS";
            this.TBWS.Size = new System.Drawing.Size(100, 20);
            this.TBWS.TabIndex = 7;
            this.TBWS.TextChanged += new System.EventHandler(this.TBWS_TextChanged);
            // 
            // TBState
            // 
            this.TBState.Location = new System.Drawing.Point(678, 446);
            this.TBState.Name = "TBState";
            this.TBState.Size = new System.Drawing.Size(100, 20);
            this.TBState.TabIndex = 8;
            this.TBState.TextChanged += new System.EventHandler(this.TBState_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(362, 420);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Таб. Номер";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(466, 420);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox6.Size = new System.Drawing.Size(100, 13);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "ФИО";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Window;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(572, 472);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox7.Size = new System.Drawing.Size(200, 13);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "Время";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Window;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(678, 420);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox8.Size = new System.Drawing.Size(100, 13);
            this.textBox8.TabIndex = 13;
            this.textBox8.Text = "Состояние прохода";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Window;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(572, 420);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox9.Size = new System.Drawing.Size(100, 13);
            this.textBox9.TabIndex = 12;
            this.textBox9.Text = "Цех";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(572, 491);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CBtime
            // 
            this.CBtime.AutoSize = true;
            this.CBtime.Location = new System.Drawing.Point(450, 491);
            this.CBtime.Name = "CBtime";
            this.CBtime.Size = new System.Drawing.Size(116, 17);
            this.CBtime.TabIndex = 15;
            this.CBtime.Text = "Учитывать время";
            this.CBtime.UseVisualStyleBackColor = true;
            this.CBtime.CheckedChanged += new System.EventHandler(this.CBtime_CheckedChanged);
            // 
            // TurniketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.CBtime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.TBState);
            this.Controls.Add(this.TBWS);
            this.Controls.Add(this.TBfio);
            this.Controls.Add(this.TBnum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TurniketForm";
            this.Text = "Турникеты";
            this.Load += new System.EventHandler(this.TurniketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox TBnum;
        public System.Windows.Forms.TextBox TBfio;
        public System.Windows.Forms.TextBox TBWS;
        public System.Windows.Forms.TextBox TBState;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox CBtime;
    }
}