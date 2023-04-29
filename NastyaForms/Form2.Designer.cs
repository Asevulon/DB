namespace DB
{
    partial class EmploeesForm
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
            this.Employees = new System.Windows.Forms.DataGridView();
            this.delete_emp = new System.Windows.Forms.Button();
            this.change_emp = new System.Windows.Forms.Button();
            this.add_emp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.list_brigada = new System.Windows.Forms.ComboBox();
            this.list_post = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.TextBox();
            this.clear_filter = new System.Windows.Forms.Button();
            this.data_on_work = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Employees)).BeginInit();
            this.SuspendLayout();
            // 
            // Employees
            // 
            this.Employees.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employees.Location = new System.Drawing.Point(1, 3);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(796, 391);
            this.Employees.TabIndex = 0;
            // 
            // delete_emp
            // 
            this.delete_emp.Location = new System.Drawing.Point(713, 415);
            this.delete_emp.Name = "delete_emp";
            this.delete_emp.Size = new System.Drawing.Size(75, 23);
            this.delete_emp.TabIndex = 1;
            this.delete_emp.Text = "Удалить";
            this.delete_emp.UseVisualStyleBackColor = true;
            this.delete_emp.Click += new System.EventHandler(this.delete_emp_Click);
            // 
            // change_emp
            // 
            this.change_emp.Location = new System.Drawing.Point(632, 415);
            this.change_emp.Name = "change_emp";
            this.change_emp.Size = new System.Drawing.Size(75, 23);
            this.change_emp.TabIndex = 2;
            this.change_emp.Text = "Изменить";
            this.change_emp.UseVisualStyleBackColor = true;
            this.change_emp.Click += new System.EventHandler(this.change_emp_Click);
            // 
            // add_emp
            // 
            this.add_emp.Location = new System.Drawing.Point(551, 415);
            this.add_emp.Name = "add_emp";
            this.add_emp.Size = new System.Drawing.Size(75, 23);
            this.add_emp.TabIndex = 3;
            this.add_emp.Text = "Добавить";
            this.add_emp.UseVisualStyleBackColor = true;
            this.add_emp.Click += new System.EventHandler(this.add_emp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Настроить бригады";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Настроить цехи";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Настроить должности";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(12, 460);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(324, 20);
            this.FIO.TabIndex = 7;
            this.FIO.TextChanged += new System.EventHandler(this.FIO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Табельный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Дата приема на работу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Номер бригады";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Должность";
            // 
            // list_brigada
            // 
            this.list_brigada.FormattingEnabled = true;
            this.list_brigada.Location = new System.Drawing.Point(353, 459);
            this.list_brigada.Name = "list_brigada";
            this.list_brigada.Size = new System.Drawing.Size(324, 21);
            this.list_brigada.TabIndex = 18;
            this.list_brigada.SelectedIndexChanged += new System.EventHandler(this.list_brigada_SelectedIndexChanged);
            // 
            // list_post
            // 
            this.list_post.FormattingEnabled = true;
            this.list_post.Location = new System.Drawing.Point(353, 498);
            this.list_post.Name = "list_post";
            this.list_post.Size = new System.Drawing.Size(324, 21);
            this.list_post.TabIndex = 19;
            this.list_post.SelectedIndexChanged += new System.EventHandler(this.list_post_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(12, 498);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(324, 20);
            this.id.TabIndex = 20;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // clear_filter
            // 
            this.clear_filter.Location = new System.Drawing.Point(353, 533);
            this.clear_filter.Name = "clear_filter";
            this.clear_filter.Size = new System.Drawing.Size(324, 23);
            this.clear_filter.TabIndex = 22;
            this.clear_filter.Text = "Сбросить фильтр";
            this.clear_filter.UseVisualStyleBackColor = true;
            this.clear_filter.Click += new System.EventHandler(this.clear_filter_Click);
            // 
            // data_on_work
            // 
            this.data_on_work.Location = new System.Drawing.Point(12, 536);
            this.data_on_work.Name = "data_on_work";
            this.data_on_work.Size = new System.Drawing.Size(324, 20);
            this.data_on_work.TabIndex = 23;
            this.data_on_work.ValueChanged += new System.EventHandler(this.data_on_work_ValueChanged);
            // 
            // EmploeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.data_on_work);
            this.Controls.Add(this.clear_filter);
            this.Controls.Add(this.id);
            this.Controls.Add(this.list_post);
            this.Controls.Add(this.list_brigada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_emp);
            this.Controls.Add(this.change_emp);
            this.Controls.Add(this.delete_emp);
            this.Controls.Add(this.Employees);
            this.Name = "EmploeesForm";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.Employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Employees;
        private System.Windows.Forms.Button delete_emp;
        private System.Windows.Forms.Button change_emp;
        private System.Windows.Forms.Button add_emp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox list_brigada;
        private System.Windows.Forms.ComboBox list_post;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button clear_filter;
        private System.Windows.Forms.DateTimePicker data_on_work;
    }
}