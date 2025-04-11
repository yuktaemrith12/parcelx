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
        public static string dataFilePath = ""; // Will be set via user input

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FilePath filePathForm = new FilePath();
            DialogResult result = filePathForm.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Ignore)
            {
                Application.Run(new Menu());
            }
            else
            {
                Application.Exit();
            }
        }

        public static void LoadPostmanData()
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

                    // Check if PostmanTbl has any data
                    SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM PostmanTbl", con);
                    int rowCount = (int)countCmd.ExecuteScalar();

                    // Read all lines from text file
                    string[] lines = File.ReadAllLines(dataFilePath);
                    List<int> existingOfficerIDs = new List<int>();

                    if (rowCount > 0)
                    {
                        // Fetch existing OfficerIDs to check for duplicates
                        SqlCommand fetchCmd = new SqlCommand("SELECT OfficerID FROM PostmanTbl", con);
                        using (SqlDataReader reader = fetchCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                existingOfficerIDs.Add(reader.GetInt32(0));
                            }
                        }
                    }

                    // Enable identity insert
                    SqlCommand enableIdentityCmd = new SqlCommand("SET IDENTITY_INSERT PostmanTbl ON;", con);
                    enableIdentityCmd.ExecuteNonQuery();

                    int insertedCount = 0;

                    foreach (string line in lines)
                    {
                        string[] data = line.Split(',');

                        if (data.Length == 6)
                        {
                            int officerID = int.Parse(data[0]);

                            // Insert only if not already in the table
                            if (!existingOfficerIDs.Contains(officerID))
                            {
                                SqlCommand insertCmd = new SqlCommand(@"
                                INSERT INTO PostmanTbl (OfficerID, OfficerName, OfficerAddress, OfficerContact, HireDate, Employment)
                                VALUES (@ID, @Name, @Address, @Contact, @HireDate, @Employment)", con);

                                insertCmd.Parameters.AddWithValue("@ID", officerID);
                                insertCmd.Parameters.AddWithValue("@Name", data[1]);
                                insertCmd.Parameters.AddWithValue("@Address", data[2]);
                                insertCmd.Parameters.AddWithValue("@Contact", data[3]);
                                insertCmd.Parameters.AddWithValue("@HireDate", DateTime.Parse(data[4]));
                                insertCmd.Parameters.AddWithValue("@Employment", data[5]);

                                insertCmd.ExecuteNonQuery();
                                insertedCount++;
                            }
                        }
                    }

                    // Disable identity insert
                    SqlCommand disableIdentityCmd = new SqlCommand("SET IDENTITY_INSERT PostmanTbl OFF;", con);
                    disableIdentityCmd.ExecuteNonQuery();

                    MessageBox.Show($"{insertedCount} new officer(s) added to the database.", "Data Load Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool DatabaseHasPostmanData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PostmanTbl", con);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
