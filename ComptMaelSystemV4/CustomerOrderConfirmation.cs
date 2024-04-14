using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComptMaelSystemV4
{
    public class CustomerOrderConfirmation
    {

        public bool IsCorrect { get; set; }
        public string ErrorType { get; set; }

        public void CreateTable(List<Order> orders)
        {
            // Create a new DataGridView control
            DataGridView weeklyOrderTable = new DataGridView();

            // Add columns to the DataGridView control
            weeklyOrderTable.AutoGenerateColumns = true; // Automatically generate columns based on the Order properties
            weeklyOrderTable.DataSource = orders;


        }
        private void FillTable(DataGridView dataGridView, List<string> values)
        {
           
            }
        }
    }

