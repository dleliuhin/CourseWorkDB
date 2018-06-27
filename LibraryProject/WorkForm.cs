﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }
    }
}
