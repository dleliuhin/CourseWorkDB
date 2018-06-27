namespace LibraryProject
{
    partial class BooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Del_button = new System.Windows.Forms.Button();
            this.List_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Clr_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.IDbook_textBox = new System.Windows.Forms.TextBox();
            this.Count_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Type_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LibraryProject.Properties.Resources.Books;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1111, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Del_button
            // 
            this.Del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del_button.Location = new System.Drawing.Point(71, 341);
            this.Del_button.Name = "Del_button";
            this.Del_button.Size = new System.Drawing.Size(154, 49);
            this.Del_button.TabIndex = 35;
            this.Del_button.Text = "Удалить";
            this.Del_button.UseVisualStyleBackColor = true;
            this.Del_button.Click += new System.EventHandler(this.Del_button_Click);
            // 
            // List_button
            // 
            this.List_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_button.Location = new System.Drawing.Point(71, 49);
            this.List_button.Name = "List_button";
            this.List_button.Size = new System.Drawing.Size(154, 49);
            this.List_button.TabIndex = 34;
            this.List_button.Text = "Список";
            this.List_button.UseVisualStyleBackColor = true;
            this.List_button.Click += new System.EventHandler(this.List_button_Click_1);
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(71, 146);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(154, 49);
            this.Add_button.TabIndex = 33;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Clr_button
            // 
            this.Clr_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clr_button.Location = new System.Drawing.Point(71, 240);
            this.Clr_button.Name = "Clr_button";
            this.Clr_button.Size = new System.Drawing.Size(154, 49);
            this.Clr_button.TabIndex = 32;
            this.Clr_button.Text = "Очистить";
            this.Clr_button.UseVisualStyleBackColor = true;
            this.Clr_button.Click += new System.EventHandler(this.Clr_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_button.Location = new System.Drawing.Point(71, 446);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(154, 49);
            this.Update_button.TabIndex = 31;
            this.Update_button.Text = "Обновить";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(71, 654);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(154, 49);
            this.Exit_button.TabIndex = 30;
            this.Exit_button.Text = "Выход";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(71, 550);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(154, 49);
            this.Back_button.TabIndex = 29;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click_1);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToOrderColumns = true;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(335, 329);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(704, 374);
            this.dgvBooks.TabIndex = 28;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // IDbook_textBox
            // 
            this.IDbook_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDbook_textBox.Location = new System.Drawing.Point(711, 49);
            this.IDbook_textBox.Name = "IDbook_textBox";
            this.IDbook_textBox.Size = new System.Drawing.Size(313, 31);
            this.IDbook_textBox.TabIndex = 36;
            this.IDbook_textBox.Text = "2";
            // 
            // Count_textBox
            // 
            this.Count_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_textBox.Location = new System.Drawing.Point(711, 197);
            this.Count_textBox.Name = "Count_textBox";
            this.Count_textBox.Size = new System.Drawing.Size(313, 31);
            this.Count_textBox.TabIndex = 37;
            this.Count_textBox.Text = "100";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_textBox.Location = new System.Drawing.Point(711, 123);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(313, 31);
            this.Name_textBox.TabIndex = 38;
            this.Name_textBox.Text = "Программирование на C++";
            // 
            // Type_textBox
            // 
            this.Type_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type_textBox.Location = new System.Drawing.Point(711, 271);
            this.Type_textBox.Name = "Type_textBox";
            this.Type_textBox.Size = new System.Drawing.Size(313, 31);
            this.Type_textBox.TabIndex = 39;
            this.Type_textBox.Text = "1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(512, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 40;
            this.label2.Text = "ID книги";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(508, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(515, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 31);
            this.label3.TabIndex = 42;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(515, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 31);
            this.label4.TabIndex = 43;
            this.label4.Text = "№ типа книг";
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 753);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Type_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Count_textBox);
            this.Controls.Add(this.IDbook_textBox);
            this.Controls.Add(this.Del_button);
            this.Controls.Add(this.List_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Clr_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1129, 801);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1129, 801);
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BooksForm_FormClosed);
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Del_button;
        private System.Windows.Forms.Button List_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Clr_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox IDbook_textBox;
        private System.Windows.Forms.TextBox Count_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Type_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}