namespace LibraryProject
{
    partial class BookTypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTypesForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Del_button = new System.Windows.Forms.Button();
            this.List_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Clr_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.dgvBT = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.IDtype_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Nametype_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountType_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FineType_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DayCount_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LibraryProject.Properties.Resources.Booktypes;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1111, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Del_button
            // 
            this.Del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del_button.Location = new System.Drawing.Point(70, 332);
            this.Del_button.Name = "Del_button";
            this.Del_button.Size = new System.Drawing.Size(154, 49);
            this.Del_button.TabIndex = 36;
            this.Del_button.Text = "Удалить";
            this.Del_button.UseVisualStyleBackColor = true;
            this.Del_button.Click += new System.EventHandler(this.Del_button_Click);
            // 
            // List_button
            // 
            this.List_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_button.Location = new System.Drawing.Point(70, 40);
            this.List_button.Name = "List_button";
            this.List_button.Size = new System.Drawing.Size(154, 49);
            this.List_button.TabIndex = 35;
            this.List_button.Text = "Список";
            this.List_button.UseVisualStyleBackColor = true;
            this.List_button.Click += new System.EventHandler(this.List_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(70, 137);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(154, 49);
            this.Add_button.TabIndex = 34;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Clr_button
            // 
            this.Clr_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clr_button.Location = new System.Drawing.Point(70, 231);
            this.Clr_button.Name = "Clr_button";
            this.Clr_button.Size = new System.Drawing.Size(154, 49);
            this.Clr_button.TabIndex = 33;
            this.Clr_button.Text = "Очистить";
            this.Clr_button.UseVisualStyleBackColor = true;
            this.Clr_button.Click += new System.EventHandler(this.Clr_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_button.Location = new System.Drawing.Point(70, 437);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(154, 49);
            this.Update_button.TabIndex = 32;
            this.Update_button.Text = "Обновить";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(70, 645);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(154, 49);
            this.Exit_button.TabIndex = 31;
            this.Exit_button.Text = "Выход";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(70, 541);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(154, 49);
            this.Back_button.TabIndex = 30;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // dgvBT
            // 
            this.dgvBT.AllowUserToOrderColumns = true;
            this.dgvBT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBT.Location = new System.Drawing.Point(334, 320);
            this.dgvBT.Name = "dgvBT";
            this.dgvBT.RowTemplate.Height = 24;
            this.dgvBT.Size = new System.Drawing.Size(704, 374);
            this.dgvBT.TabIndex = 29;
            this.dgvBT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBT_CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::LibraryProject.Properties.Resources.Clients;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1111, 753);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // IDtype_textBox
            // 
            this.IDtype_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDtype_textBox.Location = new System.Drawing.Point(754, 40);
            this.IDtype_textBox.Name = "IDtype_textBox";
            this.IDtype_textBox.Size = new System.Drawing.Size(228, 31);
            this.IDtype_textBox.TabIndex = 38;
            this.IDtype_textBox.Text = "5";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(701, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 31);
            this.label6.TabIndex = 37;
            this.label6.Text = "ID";
            // 
            // Nametype_textBox
            // 
            this.Nametype_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nametype_textBox.Location = new System.Drawing.Point(754, 96);
            this.Nametype_textBox.Name = "Nametype_textBox";
            this.Nametype_textBox.Size = new System.Drawing.Size(228, 31);
            this.Nametype_textBox.TabIndex = 40;
            this.Nametype_textBox.Text = "Распространенный";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(559, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 39;
            this.label1.Text = "Классификация";
            // 
            // CountType_textBox
            // 
            this.CountType_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountType_textBox.Location = new System.Drawing.Point(754, 155);
            this.CountType_textBox.Name = "CountType_textBox";
            this.CountType_textBox.Size = new System.Drawing.Size(228, 31);
            this.CountType_textBox.TabIndex = 42;
            this.CountType_textBox.Text = "8";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(564, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 31);
            this.label2.TabIndex = 41;
            this.label2.Text = "Кол-во";
            // 
            // FineType_textBox
            // 
            this.FineType_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FineType_textBox.Location = new System.Drawing.Point(754, 213);
            this.FineType_textBox.Name = "FineType_textBox";
            this.FineType_textBox.Size = new System.Drawing.Size(228, 31);
            this.FineType_textBox.TabIndex = 44;
            this.FineType_textBox.Text = "250";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(554, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 31);
            this.label3.TabIndex = 43;
            this.label3.Text = "Размер штрафа";
            // 
            // DayCount_textBox
            // 
            this.DayCount_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayCount_textBox.Location = new System.Drawing.Point(754, 271);
            this.DayCount_textBox.Name = "DayCount_textBox";
            this.DayCount_textBox.Size = new System.Drawing.Size(228, 31);
            this.DayCount_textBox.TabIndex = 46;
            this.DayCount_textBox.Text = "10";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(549, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 31);
            this.label4.TabIndex = 45;
            this.label4.Text = "Кол-во дней";
            // 
            // BookTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 753);
            this.Controls.Add(this.DayCount_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FineType_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CountType_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nametype_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDtype_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Del_button);
            this.Controls.Add(this.List_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Clr_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.dgvBT);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1129, 801);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1129, 801);
            this.Name = "BookTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Типы книг";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookTypesForm_FormClosed);
            this.Load += new System.EventHandler(this.BookTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvBT;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox IDtype_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nametype_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountType_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FineType_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DayCount_textBox;
        private System.Windows.Forms.Label label4;
    }
}