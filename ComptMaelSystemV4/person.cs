using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComptMaelSystemV4
{
    public class Person
    {
       
        public string UserName { get; set; }
        public string Password { get; set; }

        public Person(string userName, string password)
        {
            
            UserName = userName;
            Password = password;
        }
        public bool InputCredentials(string username, string password)
        {
            Login login = new Login(); // Assuming Login class is accessible
            if (login.VerifyCredentials(username, password))
            {
                MessageBox.Show("Succesful Login");// Credentials are valid, display module selection form
                ModulePage modulepage = new ModulePage();

                modulepage.Show();
                return true;
                
            }
            else
            {
                // Credentials are invalid, display message box
                MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
