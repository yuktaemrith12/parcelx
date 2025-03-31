using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using PostalCW.DataStructures;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace PostalCW
{
    internal static class Program
    {
        public static string connectionString = @"Data Source=YUK;Initial Catalog=ParcelX_dB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public static string dataFilePath = "C:\\Users\\yukta\\OneDrive - Middlesex University\\CSSE Year 2\\M3 Software Engineering Management and Development\\CW - PostalMangementSystem\\PostalCW\\PostalCW\\PostmanData.txt"; // Path to text file

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadPostmanData(); //Load data from text file into DB

            Application.Run(new Menu());

            // Cleanup database on logout
            DeletePostmanData();
        }

        // Load Data from Text File to Database
        private static void LoadPostmanData()
        {
            try
            {
                if (!File.Exists(dataFilePath))
                {
                    MessageBox.Show("Data file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Clear the table first (To avoid duplicates if the program restarts)
                    SqlCommand clearCmd = new SqlCommand("DELETE FROM PostmanTbl", con);
                    clearCmd.ExecuteNonQuery();

                    // Enable IDENTITY_INSERT to allow inserting OfficerID
                    SqlCommand enableIdentityCmd = new SqlCommand("SET IDENTITY_INSERT PostmanTbl ON;", con);
                    enableIdentityCmd.ExecuteNonQuery();

                    // Read all lines from the text file
                    string[] lines = File.ReadAllLines(dataFilePath);
                    foreach (string line in lines)
                    {
                        string[] data = line.Split(','); 

                        if (data.Length == 6) 
                        {
                            using (SqlCommand insertCmd = new SqlCommand(@"
                                INSERT INTO PostmanTbl (OfficerID, OfficerName, OfficerAddress, OfficerContact, HireDate, Employment)
                                VALUES (@ID, @Name, @Address, @Contact, @HireDate, @Employment)", con))
                            {
                                insertCmd.Parameters.AddWithValue("@ID", int.Parse(data[0]));  
                                insertCmd.Parameters.AddWithValue("@Name", data[1]);
                                insertCmd.Parameters.AddWithValue("@Address", data[2]);
                                insertCmd.Parameters.AddWithValue("@Contact", data[3]);
                                insertCmd.Parameters.AddWithValue("@HireDate", DateTime.Parse(data[4])); 
                                insertCmd.Parameters.AddWithValue("@Employment", data[5]);

                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Disable IDENTITY_INSERT after inserting data
                    SqlCommand disableIdentityCmd = new SqlCommand("SET IDENTITY_INSERT PostmanTbl OFF;", con);
                    disableIdentityCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete Data on Logout
        private static void DeletePostmanData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM PostmanTbl;", con);
                    deleteCmd.ExecuteNonQuery();
                }

                MessageBox.Show("All session data has been cleared. Logging out...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during logout: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
