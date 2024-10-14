using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_ACT1_046_Pattaguan
{
    public partial class frmDeleteRecord : Form
    {
        private readonly string connectionStr = "server=localhost; database=db_act1; uid=root; pwd=uslt; port=3306;";
        MySqlConnection conn;

        public frmDeleteRecord()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM car WHERE Model=@Model";

            using (MySqlConnection conn = new MySqlConnection(connectionStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@Brand", cbCars.Text);
                    
                    try
                    {
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{result} row(s) deleted successfully.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }
    }
}
