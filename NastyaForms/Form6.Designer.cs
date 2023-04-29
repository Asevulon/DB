namespace DB
{
    partial class Form6
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
            this.table_workshop = new System.Windows.Forms.DataGridView();
            this.delete_workshop = new System.Windows.Forms.Button();
            this.change_workshop = new System.Windows.Forms.Button();
            this.add_workshop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_workshop)).BeginInit();
            this.SuspendLayout();
            // 
            // table_workshop
            // 
            this.table_workshop.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table_workshop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_workshop.Location = new System.Drawing.Point(3, 3);
            this.table_workshop.Name = "table_workshop";
            this.table_workshop.Size = new System.Drawing.Size(561, 254);
            this.table_workshop.TabIndex = 0;
            // 
            // delete_workshop
            // 
            this.delete_workshop.Location = new System.Drawing.Point(478, 268);
            this.delete_workshop.Name = "delete_workshop";
            this.delete_workshop.Size = new System.Drawing.Size(75, 23);
            this.delete_workshop.TabIndex = 1;
            this.delete_workshop.Text = "Удалить";
            this.delete_workshop.UseVisualStyleBackColor = true;
            this.delete_workshop.Click += new System.EventHandler(this.delete_workshop_Click);
            // 
            // change_workshop
            // 
            this.change_workshop.Location = new System.Drawing.Point(397, 268);
            this.change_workshop.Name = "change_workshop";
            this.change_workshop.Size = new System.Drawing.Size(75, 23);
            this.change_workshop.TabIndex = 2;
            this.change_workshop.Text = "Изменить";
            this.change_workshop.UseVisualStyleBackColor = true;
            this.change_workshop.Click += new System.EventHandler(this.change_workshop_Click);
            // 
            // add_workshop
            // 
            this.add_workshop.Location = new System.Drawing.Point(316, 268);
            this.add_workshop.Name = "add_workshop";
            this.add_workshop.Size = new System.Drawing.Size(75, 23);
            this.add_workshop.TabIndex = 3;
            this.add_workshop.Text = "Добавить";
            this.add_workshop.UseVisualStyleBackColor = true;
            this.add_workshop.Click += new System.EventHandler(this.add_workshop_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 303);
            this.Controls.Add(this.add_workshop);
            this.Controls.Add(this.change_workshop);
            this.Controls.Add(this.delete_workshop);
            this.Controls.Add(this.table_workshop);
            this.Name = "Form6";
            this.Text = "Цех";
            ((System.ComponentModel.ISupportInitialize)(this.table_workshop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table_workshop;
        private System.Windows.Forms.Button delete_workshop;
        private System.Windows.Forms.Button change_workshop;
        private System.Windows.Forms.Button add_workshop;
    }
}