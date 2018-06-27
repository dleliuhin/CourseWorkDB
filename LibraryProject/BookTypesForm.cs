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
    public partial class BookTypesForm : Form
    {
        OracleConnection conn = new OracleConnection();

        public BookTypesForm()
        {
            InitializeComponent();
        }

        private void BookTypesForm_Load(object sender, EventArgs e)
        {
            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = Variables.connString;
            }

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            OracleCommand cmdBookTypes = new OracleCommand();
            cmdBookTypes.CommandText = "SELECT * FROM BOOK_TYPES";
            cmdBookTypes.Connection = conn;
            cmdBookTypes.CommandType = CommandType.Text;

            OracleDataAdapter adapterBookTypes = new OracleDataAdapter(cmdBookTypes);
            DataTable dtBookTypes = new DataTable();
            adapterBookTypes.Fill(dtBookTypes);
            dgvBT.DataSource = dtBookTypes;
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
            dgvBT.DataSource = null;
            dgvBT.Rows.Clear();

            OracleCommand cmdBT = new OracleCommand();
            cmdBT.CommandText = "SELECT * FROM BOOK_TYPES";
            cmdBT.Connection = conn;
            cmdBT.CommandType = CommandType.Text;

            OracleDataAdapter adapterBT = new OracleDataAdapter(cmdBT);
            DataTable dtBT = new DataTable();
            adapterBT.Fill(dtBT);
            dgvBT.DataSource = dtBT;
            dgvBT.Refresh();
        }

        private void Clr_button_Click(object sender, EventArgs e)
        {
            dgvBT.DataSource = null;
        }

        private void BookTypesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDtype_textBox.Text) || String.IsNullOrEmpty(Nametype_textBox.Text) ||
                    String.IsNullOrEmpty(CountType_textBox.Text) || String.IsNullOrEmpty(FineType_textBox.Text)
                    || String.IsNullOrEmpty(DayCount_textBox.Text))
            {
                MessageBox.Show("Пожалуйста введите данные книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sql = "INSERT INTO BOOK_TYPES (ID,NAME,CNT,FINE,DAY_COUNT) VALUES(:ID,:NAME,:CNT,:FINE,:DAY_COUNT)";
                AUD_BookTypes(sql, 0);
            }
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDtype_textBox.Text) || String.IsNullOrEmpty(Nametype_textBox.Text) ||
                    String.IsNullOrEmpty(CountType_textBox.Text) || String.IsNullOrEmpty(FineType_textBox.Text)
                    || String.IsNullOrEmpty(DayCount_textBox.Text))
            {
                MessageBox.Show("Пожалуйста введите данные книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sql = "UPDATE BOOK_TYPES SET NAME = :NAME, CNT = :CNT, FINE = :FINE, DAY_COUNT = :DAY_COUNT, WHERE ID = :ID";
                AUD_BookTypes(sql, 1);
            }
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDtype_textBox.Text) || String.IsNullOrEmpty(Nametype_textBox.Text) ||
        String.IsNullOrEmpty(CountType_textBox.Text) || String.IsNullOrEmpty(FineType_textBox.Text)
        || String.IsNullOrEmpty(DayCount_textBox.Text))
            {
                MessageBox.Show("Пожалуйста введите данные книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sql = "DELETE FROM BOOK_TYPES WHERE ID = :ID";
                AUD_BookTypes(sql, 2);
            }
        }


        private void AUD_BookTypes(string sql, int state)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            OracleCommand cmdBookTypes = conn.CreateCommand();

            cmdBookTypes.CommandText = sql;
            cmdBookTypes.CommandType = CommandType.Text;

            switch (state)
            {
                case 0:
                    //Insert new client
                    cmdBookTypes.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(IDtype_textBox.Text);
                    cmdBookTypes.Parameters.Add("NAME", OracleDbType.Varchar2, 100).Value = Nametype_textBox.Text;
                    cmdBookTypes.Parameters.Add("CNT", OracleDbType.Int32, 6).Value = Int32.Parse(CountType_textBox.Text);
                    cmdBookTypes.Parameters.Add("FINE", OracleDbType.Int32, 6).Value = Int32.Parse(FineType_textBox.Text);
                    cmdBookTypes.Parameters.Add("DAY_COUNT", OracleDbType.Int32, 6).Value = Int32.Parse(DayCount_textBox.Text);
                    break;

                case 1:
                    //Update clients
                    cmdBookTypes.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(IDtype_textBox.Text);
                    cmdBookTypes.Parameters.Add("NAME", OracleDbType.Varchar2, 100).Value = Nametype_textBox.Text;
                    cmdBookTypes.Parameters.Add("CNT", OracleDbType.Int32, 6).Value = Int32.Parse(CountType_textBox.Text);
                    cmdBookTypes.Parameters.Add("FINE", OracleDbType.Int32, 6).Value = Int32.Parse(FineType_textBox.Text);
                    cmdBookTypes.Parameters.Add("DAY_COUNT", OracleDbType.Int32, 6).Value = Int32.Parse(DayCount_textBox.Text);
                    break;

                case 2:
                    //Delete specific client
                    cmdBookTypes.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(IDtype_textBox.Text);
                    break;
                case 3:
                    //Find specific client
                    cmdBookTypes.Parameters.Add("ID", OracleDbType.Int32, 6).Value = Int32.Parse(IDtype_textBox.Text);
                    cmdBookTypes.Parameters.Add("NAME", OracleDbType.Varchar2, 100).Value = Nametype_textBox.Text;
                    cmdBookTypes.Parameters.Add("CNT", OracleDbType.Int32, 6).Value = Int32.Parse(CountType_textBox.Text);
                    cmdBookTypes.Parameters.Add("FINE", OracleDbType.Int32, 6).Value = Int32.Parse(FineType_textBox.Text);
                    cmdBookTypes.Parameters.Add("DAY_COUNT", OracleDbType.Int32, 6).Value = Int32.Parse(DayCount_textBox.Text);
                    break;
            }
            try
            {
                int n = cmdBookTypes.ExecuteNonQuery();
                if (n > 0)
                {
                    OracleCommand cmdBookTypes1 = new OracleCommand();
                    cmdBookTypes1.CommandText = "SELECT * FROM BOOK_TYPES";
                    cmdBookTypes1.Connection = conn;
                    cmdBookTypes1.CommandType = CommandType.Text;
                    OracleDataAdapter adapterBookTypes = new OracleDataAdapter(cmdBookTypes1);
                    DataTable dtBooks = new DataTable();
                    adapterBookTypes.Fill(dtBooks);
                    dgvBT.DataSource = dtBooks;
                }
            }
            catch (Exception exep) { };
        }

        private void dgvBT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDtype_textBox.Text = dgvBT.CurrentRow.Cells[0].Value.ToString();
            Nametype_textBox.Text = dgvBT.CurrentRow.Cells[1].Value.ToString();
            CountType_textBox.Text = dgvBT.CurrentRow.Cells[2].Value.ToString();
            FineType_textBox.Text = dgvBT.CurrentRow.Cells[3].Value.ToString();
            DayCount_textBox.Text = dgvBT.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
