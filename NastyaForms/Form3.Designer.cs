namespace DB
{
    partial class Form3
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
            this.surname_emp = new System.Windows.Forms.TextBox();
            this.name_emp = new System.Windows.Forms.TextBox();
            this.patronimyc_emp = new System.Windows.Forms.TextBox();
            this.data_of_employment = new System.Windows.Forms.DateTimePicker();
            this.list_brigada = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.list_post = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // surname_emp
            // 
            this.surname_emp.Location = new System.Drawing.Point(12, 22);
            this.surname_emp.Name = "surname_emp";
            this.surname_emp.Size = new System.Drawing.Size(332, 20);
            this.surname_emp.TabIndex = 0;
            // 
            // name_emp
            // 
            this.name_emp.Location = new System.Drawing.Point(12, 63);
            this.name_emp.Name = "name_emp";
            this.name_emp.Size = new System.Drawing.Size(332, 20);
            this.name_emp.TabIndex = 1;
            // 
            // patronimyc_emp
            // 
            this.patronimyc_emp.Location = new System.Drawing.Point(12, 101);
            this.patronimyc_emp.Name = "patronimyc_emp";
            this.patronimyc_emp.Size = new System.Drawing.Size(332, 20);
            this.patronimyc_emp.TabIndex = 2;
            // 
            // data_of_employment
            // 
            this.data_of_employment.Location = new System.Drawing.Point(12, 142);
            this.data_of_employment.Name = "data_of_employment";
            this.data_of_employment.Size = new System.Drawing.Size(332, 20);
            this.data_of_employment.TabIndex = 3;
            // 
            // list_brigada
            // 
            this.list_brigada.FormattingEnabled = true;
            this.list_brigada.Location = new System.Drawing.Point(12, 186);
            this.list_brigada.Name = "list_brigada";
            this.list_brigada.Size = new System.Drawing.Size(332, 21);
            this.list_brigada.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата приема на работу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Бригада";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "ОК";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // list_post
            // 
            this.list_post.FormattingEnabled = true;
            this.list_post.Location = new System.Drawing.Point(12, 237);
            this.list_post.Name = "list_post";
            this.list_post.Size = new System.Drawing.Size(332, 21);
            this.list_post.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Должность";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 321);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.list_post);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_brigada);
            this.Controls.Add(this.data_of_employment);
            this.Controls.Add(this.patronimyc_emp);
            this.Controls.Add(this.name_emp);
            this.Controls.Add(this.surname_emp);
            this.Name = "Form3";
            this.Text = "Операции с сотрудниками";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox surname_emp;
        public System.Windows.Forms.TextBox name_emp;
        public System.Windows.Forms.TextBox patronimyc_emp;
        public System.Windows.Forms.DateTimePicker data_of_employment;
        public System.Windows.Forms.ComboBox list_brigada;
        public System.Windows.Forms.ComboBox list_post;
    }
}