using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ComptMaelSystemV4
{
    internal class Login
    {

        internal class login
        {
            public string Username { get; set; }
            public string Password { get; set; }

        }


        public bool VerifyCredentials(string username, string password)
        {
            // Assume the CSV file format is: username,password



            string filePath = @"Login_Credentials.CSV";
           


            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Read all lines from the CSV file
            string[] lines = File.ReadAllLines(filePath);

            // Iterate through each line to find matching credentials
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                if (fields.Length == 2 && fields[0] == username && fields[1] == password)
                {
                    // Credentials match
                    return true;
                }
            }

            // No matching credentials found
            return false;
        }
    }
}
