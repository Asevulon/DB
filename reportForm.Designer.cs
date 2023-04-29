namespace DB
{
    partial class reportForm
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
            this.ReportSourceType = new System.Windows.Forms.ComboBox();
            this.ReportType = new System.Windows.Forms.ComboBox();
            this.ReportSource = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportSourceType
            // 
            this.ReportSourceType.FormattingEnabled = true;
            this.ReportSourceType.Items.AddRange(new object[] {
            "Отчет по цеху",
            "Отчет по бригаде",
            "Отчет по специальности"});
            this.ReportSourceType.Location = new System.Drawing.Point(12, 12);
            this.ReportSourceType.Name = "ReportSourceType";
            this.ReportSourceType.Size = new System.Drawing.Size(205, 21);
            this.ReportSourceType.TabIndex = 0;
            this.ReportSourceType.SelectedIndexChanged += new System.EventHandler(this.ReportSourceType_SelectedIndexChanged);
            // 
            // ReportType
            // 
            this.ReportType.FormattingEnabled = true;
            this.ReportType.Items.AddRange(new object[] {
            "Отчет по работавшему количеству человек",
            "Отчет по отработанным человекочасам"});
            this.ReportType.Location = new System.Drawing.Point(241, 12);
            this.ReportType.Name = "ReportType";
            this.ReportType.Size = new System.Drawing.Size(205, 21);
            this.ReportType.TabIndex = 1;
            // 
            // ReportSource
            // 
            this.ReportSource.FormattingEnabled = true;
            this.ReportSource.Location = new System.Drawing.Point(12, 39);
            this.ReportSource.Name = "ReportSource";
            this.ReportSource.Size = new System.Drawing.Size(205, 21);
            this.ReportSource.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сформировать отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 74);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReportSource);
            this.Controls.Add(this.ReportType);
            this.Controls.Add(this.ReportSourceType);
            this.Name = "reportForm";
            this.Text = "Отчет";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ReportSourceType;
        private System.Windows.Forms.ComboBox ReportType;
        private System.Windows.Forms.ComboBox ReportSource;
        private System.Windows.Forms.Button button1;
    }
}