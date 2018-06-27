namespace LibraryProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Enter_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.84252F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(131, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.84252F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(131, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.87402F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username_textBox.Location = new System.Drawing.Point(436, 100);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(229, 39);
            this.username_textBox.TabIndex = 3;
            this.username_textBox.Text = "admin";
            // 
            // pass_textBox
            // 
            this.pass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.87402F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_textBox.Location = new System.Drawing.Point(436, 194);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.PasswordChar = '*';
            this.pass_textBox.Size = new System.Drawing.Size(229, 39);
            this.pass_textBox.TabIndex = 4;
            this.pass_textBox.Text = "datapass";
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.84252F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(455, 313);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(138, 97);
            this.Exit_button.TabIndex = 5;
            this.Exit_button.Text = "Выход";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Enter_button
            // 
            this.Enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.84252F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_button.Location = new System.Drawing.Point(170, 313);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(144, 97);
            this.Enter_button.TabIndex = 6;
            this.Enter_button.Text = "Вход";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 496);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(862, 544);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(862, 544);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Enter_button;
    }
}

