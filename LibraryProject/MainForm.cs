using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Enter_button_Click(object sender, EventArgs e)
        {
            if(username_textBox.Text == "admin")
            {
                if(pass_textBox.Text == "datapass")
                {
                    this.Hide();
                    LibraryProject.WorkForm workForm = new LibraryProject.WorkForm();
                    workForm.Show();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите правильный пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(username_textBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
