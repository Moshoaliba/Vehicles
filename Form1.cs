//Moshoaliba,K-34316345

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _34316345_SU2_ACT5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds;
        string sql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KefiloeMoshoaliba\Documents\C# proj\C# 2ND YR\34316345_SU2_ACT5\34316345_SU2_ACT5\Database1.mdf;Integrated Security=True";

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String search = $"SELECT vin_number,brand,model,year,type FROM Vehicles WHERE vin_number LIKE '%{txtSearch.Text}%' OR brand LIKE '%{txtSearch.Text}%' OR model LIKE '%{txtSearch.Text}%' OR year LIKE '%{txtSearch.Text}%' OR type LIKE '%{txtSearch.Text}%' ";
                adapter = new SqlDataAdapter(search, sql);
                ds = new DataSet();

                adapter.Fill(ds, "Table Source");

                dbView.DataSource = ds;
                dbView.DataMember = "Table Source";
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void display()
        {
            try
            {

                conn = new SqlConnection(sql);

                conn.Open();

                command = new SqlCommand("SELECT * FROM vehicles", conn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(ds, "Vehicles");

                dbView.DataSource = ds;
                dbView.DataMember = "Vehicles";

                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void displayInComboBox()
        {
            conn = new SqlConnection(sql);
            conn.Open();
            string query = "SELECT type FROM vehicles";
            command = new SqlCommand(query, conn);

            SqlDataReader reader;
            reader = command.ExecuteReader();


            while (reader.Read())
            {
                cmbType.Items.Add(reader[0].ToString());
            }

            reader.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmDelete myFormDelete = new FrmDelete();
            myFormDelete.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display();
            displayInComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(sql);
                conn.Open();

                adapter = new SqlDataAdapter();
                command = new SqlCommand($"INSERT INTO Vehicles(vin_number,brand,model,year,type) VALUES({txtVin.Text},'{txtBrand.Text}','{txtModel.Text}',{txtYear.Text},'{cmbType.SelectedItem}')", conn);

                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Vehicle added.");

            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            display();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
