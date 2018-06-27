namespace LibraryProject
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.Update_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Clr_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.List_button = new System.Windows.Forms.Button();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.FatherName_textBox = new System.Windows.Forms.TextBox();
            this.PNumber_textBox = new System.Windows.Forms.TextBox();
            this.PSeria_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Del_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(334, 320);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(704, 374);
            this.dgvClients.TabIndex = 1;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // Update_button
            // 
            this.Update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_button.Location = new System.Drawing.Point(70, 437);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(154, 49);
            this.Update_button.TabIndex = 12;
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
            this.Exit_button.TabIndex = 11;
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
            this.Back_button.TabIndex = 10;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Clr_button
            // 
            this.Clr_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clr_button.Location = new System.Drawing.Point(70, 231);
            this.Clr_button.Name = "Clr_button";
            this.Clr_button.Size = new System.Drawing.Size(154, 49);
            this.Clr_button.TabIndex = 13;
            this.Clr_button.Text = "Очистить";
            this.Clr_button.UseVisualStyleBackColor = true;
            this.Clr_button.Click += new System.EventHandler(this.Clr_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(70, 137);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(154, 49);
            this.Add_button.TabIndex = 14;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // List_button
            // 
            this.List_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List_button.Location = new System.Drawing.Point(70, 40);
            this.List_button.Name = "List_button";
            this.List_button.Size = new System.Drawing.Size(154, 49);
            this.List_button.TabIndex = 15;
            this.List_button.Text = "Список";
            this.List_button.UseVisualStyleBackColor = true;
            this.List_button.Click += new System.EventHandler(this.List_button_Click);
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName_textBox.Location = new System.Drawing.Point(810, 91);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(228, 31);
            this.FirstName_textBox.TabIndex = 16;
            this.FirstName_textBox.Text = "Иванов";
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName_textBox.Location = new System.Drawing.Point(810, 145);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(228, 31);
            this.LastName_textBox.TabIndex = 17;
            this.LastName_textBox.Text = "Иван";
            // 
            // FatherName_textBox
            // 
            this.FatherName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FatherName_textBox.Location = new System.Drawing.Point(810, 204);
            this.FatherName_textBox.Name = "FatherName_textBox";
            this.FatherName_textBox.Size = new System.Drawing.Size(228, 31);
            this.FatherName_textBox.TabIndex = 18;
            this.FatherName_textBox.Text = "Иванович";
            // 
            // PNumber_textBox
            // 
            this.PNumber_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PNumber_textBox.Location = new System.Drawing.Point(911, 263);
            this.PNumber_textBox.Name = "PNumber_textBox";
            this.PNumber_textBox.Size = new System.Drawing.Size(127, 31);
            this.PNumber_textBox.TabIndex = 19;
            this.PNumber_textBox.Text = "23415";
            // 
            // PSeria_textBox
            // 
            this.PSeria_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PSeria_textBox.Location = new System.Drawing.Point(810, 263);
            this.PSeria_textBox.Name = "PSeria_textBox";
            this.PSeria_textBox.Size = new System.Drawing.Size(35, 31);
            this.PSeria_textBox.TabIndex = 20;
            this.PSeria_textBox.Text = "N";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(668, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(663, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(616, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Паспорт, Серия";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(860, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "№";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(668, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Фамилия";
            // 
            // Del_button
            // 
            this.Del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del_button.Location = new System.Drawing.Point(70, 332);
            this.Del_button.Name = "Del_button";
            this.Del_button.Size = new System.Drawing.Size(154, 49);
            this.Del_button.TabIndex = 27;
            this.Del_button.Text = "Удалить";
            this.Del_button.UseVisualStyleBackColor = true;
            this.Del_button.Click += new System.EventHandler(this.Del_button_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(668, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 31);
            this.label6.TabIndex = 28;
            this.label6.Text = "ID Клиента";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.90551F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_textBox.Location = new System.Drawing.Point(810, 37);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(228, 31);
            this.ID_textBox.TabIndex = 29;
            this.ID_textBox.Text = "77193";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LibraryProject.Properties.Resources.Clients;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1111, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 753);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Del_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PSeria_textBox);
            this.Controls.Add(this.PNumber_textBox);
            this.Controls.Add(this.FatherName_textBox);
            this.Controls.Add(this.LastName_textBox);
            this.Controls.Add(this.FirstName_textBox);
            this.Controls.Add(this.List_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Clr_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1129, 801);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1129, 801);
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientsForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Clr_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button List_button;
        private System.Windows.Forms.TextBox FirstName_textBox;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.TextBox FatherName_textBox;
        private System.Windows.Forms.TextBox PNumber_textBox;
        private System.Windows.Forms.TextBox PSeria_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Del_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID_textBox;
    }
}