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
            Application.Run(new Menu());

        }

        
    }
}
