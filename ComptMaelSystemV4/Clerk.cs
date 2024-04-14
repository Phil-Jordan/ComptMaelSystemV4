using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComptMaelSystemV4
{
    public class Clerk : Person
    {
        public string EmployeeId { get; set; }

        public Clerk(string userName, string password, string employeeId)
        : base(userName, password)
        {
            EmployeeId = employeeId;
            
        }

       

        }
    }

