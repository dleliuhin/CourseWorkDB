using System;
using System.Resources;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
//using Oracle.DataAccess.Types;
//using Oracle.DataAccess.Client;
using System.Configuration;
using Vars.Properties;

namespace LibraryProject
{
    public partial class WorkForm : Form
    {
        OracleConnection conn = new OracleConnection();

        public WorkForm()
        {
            InitializeComponent();
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {
            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = Variables.connString;
            }

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            OracleCommand cmdJournal = new OracleCommand();
            cmdJournal.CommandText = "SELECT * FROM JOURNAL";
            cmdJournal.Connection = conn;
            cmdJournal.CommandType = CommandType.Text;

            OracleDataAdapter adapterJournal = new OracleDataAdapter(cmdJournal);
            DataTable dtJournal = new DataTable();
            adapterJournal.Fill(dtJournal);
            dgvWork.DataSource = dtJournal;
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryProject.MainForm mainForm = new LibraryProject.MainForm();
            mainForm.Show();
        }

        private void WorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Clients_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryProject.ClientsForm clientsForm = new LibraryProject.ClientsForm();
            clientsForm.Show();
        }

        private void Books_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryProject.BooksForm booksForm = new LibraryProject.BooksForm();
            booksForm.Show();
        }

        private void BookTypes_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryProject.BookTypesForm bookTypesForm = new LibraryProject.BookTypesForm();
            bookTypesForm.Show();
        }

        private void dgvWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientID_textBox.Text = dgvWork.CurrentRow.Cells[2].Value.ToString();
        }

        private void TopBook_button_Click(object sender, EventArgs e)
        {
            string topScript = File.ReadAllText("../../Scripts/top3.sql");
            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = Variables.connString;
            }

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            OracleCommand cmdJournal = new OracleCommand();
            cmdJournal.CommandText = topScript;
            cmdJournal.Connection = conn;
            cmdJournal.CommandType = CommandType.Text;

            OracleDataAdapter adapterJournal = new OracleDataAdapter(cmdJournal);
            DataTable dtJournal = new DataTable();
            adapterJournal.Fill(dtJournal);
            dgvWork.DataSource = dtJournal;
        }

        private void ClrJournal_button_Click(object sender, EventArgs e)
        {
            dgvWork.DataSource = null;
        }

        private void ListJoural_button_Click(object sender, EventArgs e)
        {
            dgvWork.DataSource = null;
            dgvWork.Rows.Clear();

            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = Variables.connString;
            }

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            OracleCommand cmdBooks = new OracleCommand();
            cmdBooks.CommandText = "SELECT * FROM JOURNAL";
            cmdBooks.Connection = conn;
            cmdBooks.CommandType = CommandType.Text;

            OracleDataAdapter adapterJournal = new OracleDataAdapter(cmdBooks);
            DataTable dtJournal = new DataTable();
            adapterJournal.Fill(dtJournal);
            dgvWork.DataSource = dtJournal;
            dgvWork.Refresh();
        }

        private void BigFine_button_Click(object sender, EventArgs e)
        {
            string topScript = File.ReadAllText("../../Scripts/MaxFine.sql");

            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = Variables.connString;
            }

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            OracleCommand cmdJournal = new OracleCommand();
            cmdJournal.CommandText = topScript;
            cmdJournal.Connection = conn;
            cmdJournal.CommandType = CommandType.Text;

            OracleDataAdapter adapterJournal = new OracleDataAdapter(cmdJournal);

            Maxfine_textBox.Text = cmdJournal.ExecuteScalar().ToString();
        }

        private void BigFineClear_button_Click(object sender, EventArgs e)
        {
            Maxfine_textBox.Text = null;
        }

        private void ClientIDClear_button_Click(object sender, EventArgs e)
        {
            ClientID_textBox.Text = null;
            ClientIDCount_textBox.Text = null;
            ClientIDFine_textBox.Text = null;
        }

        private void ClientCount_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ClientID_textBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите ID клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string topScript = File.ReadAllText("../../Scripts/BookCounter.sql");

                if (conn.ConnectionString == "")
                {
                    conn.ConnectionString = Variables.connString;
                }

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                OracleCommand cmdJournal = new OracleCommand();
                cmdJournal.CommandText = topScript;
                cmdJournal.Connection = conn;
                cmdJournal.CommandType = CommandType.Text;

                cmdJournal.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(ClientID_textBox.Text);

                ClientIDCount_textBox.Text = cmdJournal.ExecuteScalar().ToString();
            }
        }

        private void ClientFine_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ClientID_textBox.Text))
            {
                MessageBox.Show("Пожалуйста введите ID клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string topScript = File.ReadAllText("../../Scripts/SpecificFine.sql");

                if (conn.ConnectionString == "")
                {
                    conn.ConnectionString = Variables.connString;
                }

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                OracleCommand cmdJournal = new OracleCommand();
                cmdJournal.CommandText = topScript;
                cmdJournal.Connection = conn;
                cmdJournal.CommandType = CommandType.Text;

                cmdJournal.Parameters.Add("CLIENT_ID ", OracleDbType.Int32, 6).Value = Int32.Parse(ClientID_textBox.Text);

                ClientIDFine_textBox.Text = cmdJournal.ExecuteScalar().ToString();
            }
        }

        private void ClientID_textBox_TextChanged(object sender, EventArgs e)
        {
            ClientIDCount_textBox.Text = null;
            ClientIDFine_textBox.Text = null;
        }
    }
}
