namespace DB
{
    partial class Form5
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
            this.name_brigada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Workshops = new System.Windows.Forms.ComboBox();
            this.aaa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_brigada
            // 
            this.name_brigada.Location = new System.Drawing.Point(12, 22);
            this.name_brigada.Name = "name_brigada";
            this.name_brigada.Size = new System.Drawing.Size(250, 20);
            this.name_brigada.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название бригады";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(187, 97);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(106, 97);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "ОК";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Workshops
            // 
            this.Workshops.FormattingEnabled = true;
            this.Workshops.Location = new System.Drawing.Point(12, 61);
            this.Workshops.Name = "Workshops";
            this.Workshops.Size = new System.Drawing.Size(250, 21);
            this.Workshops.TabIndex = 4;
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Location = new System.Drawing.Point(12, 45);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(26, 13);
            this.aaa.TabIndex = 5;
            this.aaa.Text = "Цех";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 132);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.Workshops);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_brigada);
            this.Name = "Form5";
            this.Text = "Операция с бригадами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        public System.Windows.Forms.TextBox name_brigada;
        private System.Windows.Forms.ComboBox Workshops;
        private System.Windows.Forms.Label aaa;
    }
}