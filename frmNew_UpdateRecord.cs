using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Utilities.Collections;


namespace DB_ACT1_046_Pattaguan
{
    public partial class frmNew_UpdateRecord : Form
    {
        private readonly string connectionStr = "server=localhost; database=db_act1; uid=root; pwd=uslt; port=3306;";

        public frmNew_UpdateRecord()
        {
            InitializeComponent();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO car (ID, MODEL, BRAND, YEAR) VALUES (@ID, @Model, @Brand, @Year)";

            using (MySqlConnection conn = new MySqlConnection(connectionStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@Brand", cbBrand.Text);
                    cmd.Parameters.AddWithValue("@Year", txtYear.Text);

                    try
                    {
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{result} row(s) inserted successfully.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE car SET MODEL = @Model, BRAND = @Brand, YEAR = @Year WHERE ID = @ID";
            
            using (MySqlConnection conn = new MySqlConnection(connectionStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@Brand", cbBrand.Text);
                    cmd.Parameters.AddWithValue("@Year", txtYear.Text);

                    try
                    {
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{result} row(s) inserted successfully.");
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
