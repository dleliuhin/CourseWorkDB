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
    
    public partial class ClientsForm : Form
    {
        OracleConnection conn = new OracleConnection();

        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryProject.WorkForm workForm = new LibraryProject.WorkForm();
            workForm.Show();
        }

        private void List_button_Click(object sender, EventArgs e)
        {
            dgvClients.DataSource = null;
            dgvClients.Rows.Clear();

            OracleCommand cmdClients = new OracleCommand();
            cmdClients.CommandText = "SELECT * FROM CLIENTS";
            cmdClients.Connection = conn;
            cmdClients.CommandType = CommandType.Text;

            OracleDataAdapter adapterClients = new OracleDataAdapter(cmdClients);
            DataTable dtClients = new DataTable();
            adapterClients.Fill(dtClients);
            dgvClients.DataSource = dtClients;
            dgvClients.Refresh();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = Variables.connString;
            }

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            OracleCommand cmdClients = new OracleCommand();
            cmdClients.CommandText = "SELECT * FROM CLIENTS";
            cmdClients.Connection = conn;
            cmdClients.CommandType = CommandType.Text;

            OracleDataAdapter adapterClients = new OracleDataAdapter(cmdClients);
            DataTable dtClients = new DataTable();
            adapterClients.Fill(dtClients);
            dgvClients.DataSource = dtClients;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(ID_textBox.Text) || String.IsNullOrEmpty(FirstName_textBox.Text) ||
                String.IsNullOrEmpty(LastName_textBox.Text) || String.IsNullOrEmpty(PSeria_textBox.Text) ||
                String.IsNullOrEmpty(PNumber_textBox.Text))
            {
                MessageBox.Show("Пожалуйста введите данные клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sql = "INSERT INTO CLIENTS (ID,FIRST_NAME,LAST_NAME,FATHER_NAME,PASSPORT_SERIA,PASSPORT_NUM) VALUES(:ID,:FIRST_NAME,:LAST_NAME,:FATHER_NAME,:PASSPORT_SERIA,:PASSPORT_NUM)";
                AUD_Client(sql, 0);
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ID_textBox.Text) || String.IsNullOrEmpty(FirstName_textBox.Text) ||
                String.IsNullOrEmpty(LastName_textBox.Text) || String.IsNullOrEmpty(PSeria_textBox.Text) ||
                String.IsNullOrEmpty(PNumber_textBox.Text))
            {
                MessageBox.Show("Пожалуйста введите данные клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sql = "UPDATE CLIENTS SET FIRST_NAME = :FIRST_NAME, LAST_NAME = :LAST_NAME, FATHER_NAME = :FATHER_NAME, " +
                             "PASSPORT_SERIA = :PASSPORT_SERIA, PASSPORT_NUM = :PASSPORT_NUM, WHERE ID = :ID ";
                AUD_Client(sql, 1);
            }
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ID_textBox.Text))
            {
                MessageBox.Show("Пожалуйста введите ID клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sql = "DELETE FROM CLIENTS WHERE ID = :ID";
                AUD_Client(sql, 2);
            }
        }

        private void AUD_Client(string sql, int state)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            OracleCommand cmdClients = conn.CreateCommand();

            cmdClients.CommandText = sql;
            cmdClients.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    //Insert new client
                    cmdClients.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(ID_textBox.Text);
                    cmdClients.Parameters.Add("FIRST_NAME", OracleDbType.Varchar2, 100).Value = FirstName_textBox.Text;
                    cmdClients.Parameters.Add("LAST_NAME", OracleDbType.Varchar2, 100).Value = LastName_textBox.Text;
                    cmdClients.Parameters.Add("FATHER_NAME", OracleDbType.Varchar2, 100).Value = FatherName_textBox.Text;
                    cmdClients.Parameters.Add("PASSPORT_SERIA", OracleDbType.Varchar2, 100).Value = PSeria_textBox.Text;
                    cmdClients.Parameters.Add("PASSPORT_NUM", OracleDbType.Varchar2, 100).Value = PNumber_textBox.Text;
                    break;

                case 1:
                    //Update clients
                    cmdClients.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(ID_textBox.Text);
                    cmdClients.Parameters.Add("FIRST_NAME", OracleDbType.Varchar2, 100).Value = FirstName_textBox.Text;
                    cmdClients.Parameters.Add("LAST_NAME", OracleDbType.Varchar2, 100).Value = LastName_textBox.Text;
                    cmdClients.Parameters.Add("FATHER_NAME", OracleDbType.Varchar2, 100).Value = FatherName_textBox.Text;
                    cmdClients.Parameters.Add("PASSPORT_SERIA", OracleDbType.Varchar2, 100).Value = PSeria_textBox.Text;
                    cmdClients.Parameters.Add("PASSPORT_NUM", OracleDbType.Varchar2, 100).Value = PNumber_textBox.Text;
                    break;

                case 2:
                    //Delete specific client
                    cmdClients.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(ID_textBox.Text);
                    break;
                case 3:
                    //Find specific client
                    cmdClients.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(ID_textBox.Text);
                    cmdClients.Parameters.Add("FIRST_NAME", OracleDbType.Varchar2, 100).Value = FirstName_textBox.Text;
                    cmdClients.Parameters.Add("LAST_NAME", OracleDbType.Varchar2, 100).Value = LastName_textBox.Text;
                    cmdClients.Parameters.Add("FATHER_NAME", OracleDbType.Varchar2, 100).Value = FatherName_textBox.Text;
                    cmdClients.Parameters.Add("PASSPORT_SERIA", OracleDbType.Varchar2, 100).Value = PSeria_textBox.Text;
                    cmdClients.Parameters.Add("PASSPORT_NUM", OracleDbType.Varchar2, 100).Value = PNumber_textBox.Text;
                    break;
            }
            try
            {
                int n = cmdClients.ExecuteNonQuery();
                if (n > 0)
                {
                    OracleCommand cmdClients1 = new OracleCommand();
                    cmdClients1.CommandText = "SELECT * FROM CLIENTS";
                    cmdClients1.Connection = conn;
                    cmdClients1.CommandType = CommandType.Text;
                    OracleDataAdapter adapterClients = new OracleDataAdapter(cmdClients1);
                    DataTable dtClients = new DataTable();
                    adapterClients.Fill(dtClients);
                    dgvClients.DataSource = dtClients;
                }
            }
            catch (Exception exep) { };
        }

        private void Clr_button_Click(object sender, EventArgs e)
        {
            dgvClients.DataSource = null;
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_textBox.Text = dgvClients.CurrentRow.Cells[0].Value.ToString();
            FirstName_textBox.Text = dgvClients.CurrentRow.Cells[1].Value.ToString();
            LastName_textBox.Text = dgvClients.CurrentRow.Cells[2].Value.ToString();
            FatherName_textBox.Text = dgvClients.CurrentRow.Cells[3].Value.ToString();
            PSeria_textBox.Text = dgvClients.CurrentRow.Cells[4].Value.ToString();
            PNumber_textBox.Text = dgvClients.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
