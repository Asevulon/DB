namespace DB
{
    partial class Form4
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
            this.table_brigada = new System.Windows.Forms.DataGridView();
            this.delete_brigada = new System.Windows.Forms.Button();
            this.change_brigada = new System.Windows.Forms.Button();
            this.add_brigada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_brigada)).BeginInit();
            this.SuspendLayout();
            // 
            // table_brigada
            // 
            this.table_brigada.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table_brigada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_brigada.Location = new System.Drawing.Point(1, 2);
            this.table_brigada.Name = "table_brigada";
            this.table_brigada.Size = new System.Drawing.Size(558, 304);
            this.table_brigada.TabIndex = 0;
            // 
            // delete_brigada
            // 
            this.delete_brigada.Location = new System.Drawing.Point(474, 318);
            this.delete_brigada.Name = "delete_brigada";
            this.delete_brigada.Size = new System.Drawing.Size(75, 23);
            this.delete_brigada.TabIndex = 1;
            this.delete_brigada.Text = "Удалить";
            this.delete_brigada.UseVisualStyleBackColor = true;
            this.delete_brigada.Click += new System.EventHandler(this.delete_brigada_Click);
            // 
            // change_brigada
            // 
            this.change_brigada.Location = new System.Drawing.Point(393, 318);
            this.change_brigada.Name = "change_brigada";
            this.change_brigada.Size = new System.Drawing.Size(75, 23);
            this.change_brigada.TabIndex = 2;
            this.change_brigada.Text = "Изменить";
            this.change_brigada.UseVisualStyleBackColor = true;
            this.change_brigada.Click += new System.EventHandler(this.change_brigada_Click);
            // 
            // add_brigada
            // 
            this.add_brigada.Location = new System.Drawing.Point(312, 318);
            this.add_brigada.Name = "add_brigada";
            this.add_brigada.Size = new System.Drawing.Size(75, 23);
            this.add_brigada.TabIndex = 3;
            this.add_brigada.Text = "Добавить";
            this.add_brigada.UseVisualStyleBackColor = true;
            this.add_brigada.Click += new System.EventHandler(this.add_brigada_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 353);
            this.Controls.Add(this.add_brigada);
            this.Controls.Add(this.change_brigada);
            this.Controls.Add(this.delete_brigada);
            this.Controls.Add(this.table_brigada);
            this.Name = "Form4";
            this.Text = "Бригада";
            ((System.ComponentModel.ISupportInitialize)(this.table_brigada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table_brigada;
        private System.Windows.Forms.Button delete_brigada;
        private System.Windows.Forms.Button change_brigada;
        private System.Windows.Forms.Button add_brigada;
    }
}