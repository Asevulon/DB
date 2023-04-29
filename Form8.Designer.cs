namespace DB
{
    partial class Form8
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
            this.table_post = new System.Windows.Forms.DataGridView();
            this.delete_post = new System.Windows.Forms.Button();
            this.change_post = new System.Windows.Forms.Button();
            this.add_post = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_post)).BeginInit();
            this.SuspendLayout();
            // 
            // table_post
            // 
            this.table_post.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table_post.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_post.Location = new System.Drawing.Point(1, 2);
            this.table_post.Name = "table_post";
            this.table_post.Size = new System.Drawing.Size(607, 276);
            this.table_post.TabIndex = 0;
            // 
            // delete_post
            // 
            this.delete_post.Location = new System.Drawing.Point(523, 296);
            this.delete_post.Name = "delete_post";
            this.delete_post.Size = new System.Drawing.Size(75, 23);
            this.delete_post.TabIndex = 1;
            this.delete_post.Text = "Удалить";
            this.delete_post.UseVisualStyleBackColor = true;
            this.delete_post.Click += new System.EventHandler(this.delete_post_Click);
            // 
            // change_post
            // 
            this.change_post.Location = new System.Drawing.Point(442, 296);
            this.change_post.Name = "change_post";
            this.change_post.Size = new System.Drawing.Size(75, 23);
            this.change_post.TabIndex = 2;
            this.change_post.Text = "Изменить";
            this.change_post.UseVisualStyleBackColor = true;
            this.change_post.Click += new System.EventHandler(this.change_post_Click);
            // 
            // add_post
            // 
            this.add_post.Location = new System.Drawing.Point(361, 296);
            this.add_post.Name = "add_post";
            this.add_post.Size = new System.Drawing.Size(75, 23);
            this.add_post.TabIndex = 3;
            this.add_post.Text = "Добавить";
            this.add_post.UseVisualStyleBackColor = true;
            this.add_post.Click += new System.EventHandler(this.add_post_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 331);
            this.Controls.Add(this.add_post);
            this.Controls.Add(this.change_post);
            this.Controls.Add(this.delete_post);
            this.Controls.Add(this.table_post);
            this.Name = "Form8";
            this.Text = "Должности";
            ((System.ComponentModel.ISupportInitialize)(this.table_post)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table_post;
        private System.Windows.Forms.Button delete_post;
        private System.Windows.Forms.Button change_post;
        private System.Windows.Forms.Button add_post;
    }
}