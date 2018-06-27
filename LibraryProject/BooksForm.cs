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
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
//using Oracle.DataAccess.Types;
//using Oracle.DataAccess.Client;
using System.Configuration;
using Vars.Properties;

namespace LibraryProject
{
    public partial class BooksForm : Form
    {
        OracleConnection conn = new OracleConnection();

        public BooksForm()
        {
            InitializeComponent();
        }

        private void Back_button_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LibraryProject.WorkForm workForm = new LibraryProject.WorkForm();
            workForm.Show();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BooksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Clr_button_Click(object sender, EventArgs e)
        {
            dgvBooks.DataSource = null;
        }

        private void List_button_Click_1(object sender, EventArgs e)
        {
            dgvBooks.DataSource = null;
            dgvBooks.Rows.Clear();

            OracleCommand cmdBooks = new OracleCommand();
            cmdBooks.CommandText = "SELECT * FROM BOOKS";
            cmdBooks.Connection = conn;
            cmdBooks.CommandType = CommandType.Text;

            OracleDataAdapter adapterBooks = new OracleDataAdapter(cmdBooks);
            DataTable dtBooks = new DataTable();
            adapterBooks.Fill(dtBooks);
            dgvBooks.DataSource = dtBooks;
            dgvBooks.Refresh();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDbook_textBox.Text) || String.IsNullOrEmpty(Name_textBox.Text) ||
                String.IsNullOrEmpty(Count_textBox.Text) || String.IsNullOrEmpty(Type_textBox.Text))
            {
                MessageBox.Show("Пожалуйста введите данные книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sql = "INSERT INTO BOOKS (ID,NAME,CNT,TYPE_ID) VALUES(:ID,:NAME,:CNT,:TYPE_ID)";
                AUD_Book(sql, 0);
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDbook_textBox.Text) || String.IsNullOrEmpty(Name_textBox.Text) ||
                String.IsNullOrEmpty(Count_textBox.Text) || String.IsNullOrEmpty(Type_textBox.Text))
            {
                MessageBox.Show("Пожалуйста введите данные книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sql = "UPDATE BOOKS SET NAME = :NAME, CNT = :CNT, TYPE_ID = :TYPE_ID, WHERE ID = :ID ";
                AUD_Book(sql, 1);
            }
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDbook_textBox.Text))
            {
                MessageBox.Show("Пожалуйста введите ID книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sql = "DELETE FROM BOOKS WHERE ID = :ID";
                AUD_Book(sql, 2);
            }
        }

        private void AUD_Book(string sql, int state)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            OracleCommand cmdBooks = conn.CreateCommand();

            cmdBooks.CommandText = sql;
            cmdBooks.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    //Insert new client
                    cmdBooks.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(IDbook_textBox.Text);
                    cmdBooks.Parameters.Add("NAME", OracleDbType.Varchar2, 100).Value = Name_textBox.Text;
                    cmdBooks.Parameters.Add("CNT", OracleDbType.Int32, 6).Value = Int32.Parse(Count_textBox.Text);
                    cmdBooks.Parameters.Add("TYPE_ID", OracleDbType.Int32, 6).Value = Int32.Parse(Type_textBox.Text);
                    break;

                case 1:
                    //Update clients
                    cmdBooks.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(IDbook_textBox.Text);
                    cmdBooks.Parameters.Add("NAME", OracleDbType.Varchar2, 100).Value = Name_textBox.Text;
                    cmdBooks.Parameters.Add("CNT", OracleDbType.Int32, 6).Value = Int32.Parse(Count_textBox.Text);
                    cmdBooks.Parameters.Add("TYPE_ID", OracleDbType.Int32, 6).Value = Int32.Parse(Type_textBox.Text);
                    break;

                case 2:
                    //Delete specific client
                    cmdBooks.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(IDbook_textBox.Text);
                    break;
                case 3:
                    //Find specific client
                    cmdBooks.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(IDbook_textBox.Text);
                    cmdBooks.Parameters.Add("NAME", OracleDbType.Varchar2, 100).Value = Name_textBox.Text;
                    cmdBooks.Parameters.Add("CNT", OracleDbType.Int32, 6).Value = Int32.Parse(Count_textBox.Text);
                    cmdBooks.Parameters.Add("TYPE_ID", OracleDbType.Int32, 6).Value = Int32.Parse(Type_textBox.Text);
                    break;
            }
            try
            {
                int n = cmdBooks.ExecuteNonQuery();
                if (n > 0)
                {
                    OracleCommand cmdBooks1 = new OracleCommand();
                    cmdBooks1.CommandText = "SELECT * FROM BOOKS";
                    cmdBooks1.Connection = conn;
                    cmdBooks1.CommandType = CommandType.Text;
                    OracleDataAdapter adapterBooks = new OracleDataAdapter(cmdBooks1);
                    DataTable dtBooks = new DataTable();
                    adapterBooks.Fill(dtBooks);
                    dgvBooks.DataSource = dtBooks;
                }
            }
            catch (Exception exep) { };
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = Variables.connString;
            }

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            OracleCommand cmdBooks = new OracleCommand();
            cmdBooks.CommandText = "SELECT * FROM BOOKS";
            cmdBooks.Connection = conn;
            cmdBooks.CommandType = CommandType.Text;

            OracleDataAdapter adapterBooks = new OracleDataAdapter(cmdBooks);
            DataTable dtBooks = new DataTable();
            adapterBooks.Fill(dtBooks);
            dgvBooks.DataSource = dtBooks;
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDbook_textBox.Text = dgvBooks.CurrentRow.Cells[0].Value.ToString();
            Name_textBox.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
            Count_textBox.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
            Type_textBox.Text = dgvBooks.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
