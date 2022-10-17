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
    public partial class FrmDelete : Form
    {
        public FrmDelete()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        string sql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KefiloeMoshoaliba\Documents\C# proj\C# 2ND YR\34316345_SU2_ACT5\34316345_SU2_ACT5\Database1.mdf;Integrated Security=True";

        private void buttonD_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = $"DELETE FROM Vehicles WHERE model ='{txtDelete.Text}'";
                conn = new SqlConnection(sql);
                adapter = new SqlDataAdapter();
                command = new SqlCommand(delete, conn);
                conn.Open();

                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("Record deleted from the database");

                conn.Close();
                this.Close();

            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void display()
        {
           
        }
    }
}
