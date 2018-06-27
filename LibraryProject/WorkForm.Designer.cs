namespace LibraryProject
{
    partial class WorkForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clients_button = new System.Windows.Forms.Button();
            this.Books_button = new System.Windows.Forms.Button();
            this.BookTypes_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.dgvWork = new System.Windows.Forms.DataGridView();
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new LibraryProject.LibraryDataSet();
            this.SpecificClient_groupBox = new System.Windows.Forms.GroupBox();
            this.ClientFine_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClientCount_button = new System.Windows.Forms.Button();
            this.BigFine_groupBox = new System.Windows.Forms.GroupBox();
            this.BigFine_button = new System.Windows.Forms.Button();
            this.PopBooks_groupBox = new System.Windows.Forms.GroupBox();
            this.TopBook_button = new System.Windows.Forms.Button();
            this.UpdateJournal_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DelJournal_button = new System.Windows.Forms.Button();
            this.ClrJournal_button = new System.Windows.Forms.Button();
            this.ListJoural_button = new System.Windows.Forms.Button();
            this.AddJournal_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.SpecificClient_groupBox.SuspendLayout();
            this.BigFine_groupBox.SuspendLayout();
            this.PopBooks_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LibraryProject.Properties.Resources.Librarian;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1111, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Clients_button
            // 
            this.Clients_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients_button.Location = new System.Drawing.Point(930, 242);
            this.Clients_button.Name = "Clients_button";
            this.Clients_button.Size = new System.Drawing.Size(154, 49);
            this.Clients_button.TabIndex = 1;
            this.Clients_button.Text = "Клиенты";
            this.Clients_button.UseVisualStyleBackColor = true;
            this.Clients_button.Click += new System.EventHandler(this.Clients_button_Click);
            // 
            // Books_button
            // 
            this.Books_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Books_button.Location = new System.Drawing.Point(930, 326);
            this.Books_button.Name = "Books_button";
            this.Books_button.Size = new System.Drawing.Size(154, 49);
            this.Books_button.TabIndex = 2;
            this.Books_button.Text = "Книги";
            this.Books_button.UseVisualStyleBackColor = true;
            this.Books_button.Click += new System.EventHandler(this.Books_button_Click);
            // 
            // BookTypes_button
            // 
            this.BookTypes_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookTypes_button.Location = new System.Drawing.Point(930, 410);
            this.BookTypes_button.Name = "BookTypes_button";
            this.BookTypes_button.Size = new System.Drawing.Size(154, 49);
            this.BookTypes_button.TabIndex = 3;
            this.BookTypes_button.Text = "Типы книг";
            this.BookTypes_button.UseVisualStyleBackColor = true;
            this.BookTypes_button.Click += new System.EventHandler(this.BookTypes_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(28, 561);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(154, 49);
            this.Back_button.TabIndex = 4;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(28, 655);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(154, 49);
            this.Exit_button.TabIndex = 5;
            this.Exit_button.Text = "Выход";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // dgvWork
            // 
            this.dgvWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.Location = new System.Drawing.Point(207, 377);
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.RowTemplate.Height = 24;
            this.dgvWork.Size = new System.Drawing.Size(701, 331);
            this.dgvWork.TabIndex = 0;
            this.dgvWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWork_CellClick);
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SpecificClient_groupBox
            // 
            this.SpecificClient_groupBox.Controls.Add(this.ClientFine_button);
            this.SpecificClient_groupBox.Controls.Add(this.label4);
            this.SpecificClient_groupBox.Controls.Add(this.label3);
            this.SpecificClient_groupBox.Controls.Add(this.label1);
            this.SpecificClient_groupBox.Controls.Add(this.textBox1);
            this.SpecificClient_groupBox.Controls.Add(this.ClientCount_button);
            this.SpecificClient_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecificClient_groupBox.Location = new System.Drawing.Point(851, 26);
            this.SpecificClient_groupBox.Name = "SpecificClient_groupBox";
            this.SpecificClient_groupBox.Size = new System.Drawing.Size(233, 194);
            this.SpecificClient_groupBox.TabIndex = 7;
            this.SpecificClient_groupBox.TabStop = false;
            // 
            // ClientFine_button
            // 
            this.ClientFine_button.Location = new System.Drawing.Point(125, 154);
            this.ClientFine_button.Name = "ClientFine_button";
            this.ClientFine_button.Size = new System.Drawing.Size(89, 30);
            this.ClientFine_button.TabIndex = 14;
            this.ClientFine_button.Text = "Найти";
            this.ClientFine_button.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Размер штрафа клиента";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID клиента";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Число книг у клиента";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 28);
            this.textBox1.TabIndex = 10;
            // 
            // ClientCount_button
            // 
            this.ClientCount_button.Location = new System.Drawing.Point(125, 89);
            this.ClientCount_button.Name = "ClientCount_button";
            this.ClientCount_button.Size = new System.Drawing.Size(89, 30);
            this.ClientCount_button.TabIndex = 9;
            this.ClientCount_button.Text = "Найти";
            this.ClientCount_button.UseVisualStyleBackColor = true;
            // 
            // BigFine_groupBox
            // 
            this.BigFine_groupBox.Controls.Add(this.BigFine_button);
            this.BigFine_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigFine_groupBox.Location = new System.Drawing.Point(930, 482);
            this.BigFine_groupBox.Name = "BigFine_groupBox";
            this.BigFine_groupBox.Size = new System.Drawing.Size(154, 105);
            this.BigFine_groupBox.TabIndex = 8;
            this.BigFine_groupBox.TabStop = false;
            this.BigFine_groupBox.Text = "Самый большой штраф";
            // 
            // BigFine_button
            // 
            this.BigFine_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigFine_button.Location = new System.Drawing.Point(49, 64);
            this.BigFine_button.Name = "BigFine_button";
            this.BigFine_button.Size = new System.Drawing.Size(89, 30);
            this.BigFine_button.TabIndex = 10;
            this.BigFine_button.Text = "Найти";
            this.BigFine_button.UseVisualStyleBackColor = true;
            // 
            // PopBooks_groupBox
            // 
            this.PopBooks_groupBox.Controls.Add(this.TopBook_button);
            this.PopBooks_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PopBooks_groupBox.Location = new System.Drawing.Point(930, 608);
            this.PopBooks_groupBox.Name = "PopBooks_groupBox";
            this.PopBooks_groupBox.Size = new System.Drawing.Size(154, 100);
            this.PopBooks_groupBox.TabIndex = 8;
            this.PopBooks_groupBox.TabStop = false;
            this.PopBooks_groupBox.Text = "Топ-3 популярных книг";
            // 
            // TopBook_button
            // 
            this.TopBook_button.Location = new System.Drawing.Point(50, 64);
            this.TopBook_button.Name = "TopBook_button";
            this.TopBook_button.Size = new System.Drawing.Size(89, 30);
            this.TopBook_button.TabIndex = 10;
            this.TopBook_button.Text = "Найти";
            this.TopBook_button.UseVisualStyleBackColor = true;
            // 
            // UpdateJournal_button
            // 
            this.UpdateJournal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateJournal_button.Location = new System.Drawing.Point(28, 468);
            this.UpdateJournal_button.Name = "UpdateJournal_button";
            this.UpdateJournal_button.Size = new System.Drawing.Size(154, 49);
            this.UpdateJournal_button.TabIndex = 9;
            this.UpdateJournal_button.Text = "Обновить";
            this.UpdateJournal_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.17323F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(495, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Журнал";
            // 
            // DelJournal_button
            // 
            this.DelJournal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelJournal_button.Location = new System.Drawing.Point(28, 382);
            this.DelJournal_button.Name = "DelJournal_button";
            this.DelJournal_button.Size = new System.Drawing.Size(154, 49);
            this.DelJournal_button.TabIndex = 39;
            this.DelJournal_button.Text = "Удалить";
            this.DelJournal_button.UseVisualStyleBackColor = true;
            // 
            // ClrJournal_button
            // 
            this.ClrJournal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClrJournal_button.Location = new System.Drawing.Point(28, 296);
            this.ClrJournal_button.Name = "ClrJournal_button";
            this.ClrJournal_button.Size = new System.Drawing.Size(154, 49);
            this.ClrJournal_button.TabIndex = 36;
            this.ClrJournal_button.Text = "Очистить";
            this.ClrJournal_button.UseVisualStyleBackColor = true;
            // 
            // ListJoural_button
            // 
            this.ListJoural_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListJoural_button.Location = new System.Drawing.Point(28, 128);
            this.ListJoural_button.Name = "ListJoural_button";
            this.ListJoural_button.Size = new System.Drawing.Size(154, 49);
            this.ListJoural_button.TabIndex = 41;
            this.ListJoural_button.Text = "Список";
            this.ListJoural_button.UseVisualStyleBackColor = true;
            // 
            // AddJournal_button
            // 
            this.AddJournal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20472F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddJournal_button.Location = new System.Drawing.Point(28, 212);
            this.AddJournal_button.Name = "AddJournal_button";
            this.AddJournal_button.Size = new System.Drawing.Size(154, 49);
            this.AddJournal_button.TabIndex = 40;
            this.AddJournal_button.Text = "Добавить";
            this.AddJournal_button.UseVisualStyleBackColor = true;
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 753);
            this.Controls.Add(this.ListJoural_button);
            this.Controls.Add(this.PopBooks_groupBox);
            this.Controls.Add(this.ClrJournal_button);
            this.Controls.Add(this.BigFine_groupBox);
            this.Controls.Add(this.DelJournal_button);
            this.Controls.Add(this.AddJournal_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateJournal_button);
            this.Controls.Add(this.SpecificClient_groupBox);
            this.Controls.Add(this.dgvWork);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.BookTypes_button);
            this.Controls.Add(this.Books_button);
            this.Controls.Add(this.Clients_button);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkForm_FormClosed);
            this.Load += new System.EventHandler(this.WorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.SpecificClient_groupBox.ResumeLayout(false);
            this.SpecificClient_groupBox.PerformLayout();
            this.BigFine_groupBox.ResumeLayout(false);
            this.PopBooks_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Clients_button;
        private System.Windows.Forms.Button Books_button;
        private System.Windows.Forms.Button BookTypes_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.DataGridView dgvWork;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.GroupBox SpecificClient_groupBox;
        private System.Windows.Forms.GroupBox BigFine_groupBox;
        private System.Windows.Forms.GroupBox PopBooks_groupBox;
        private System.Windows.Forms.Button ClientCount_button;
        private System.Windows.Forms.Button BigFine_button;
        private System.Windows.Forms.Button TopBook_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button UpdateJournal_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DelJournal_button;
        private System.Windows.Forms.Button ClrJournal_button;
        private System.Windows.Forms.Button ListJoural_button;
        private System.Windows.Forms.Button AddJournal_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClientFine_button;
        private System.Windows.Forms.Label label4;
    }
}