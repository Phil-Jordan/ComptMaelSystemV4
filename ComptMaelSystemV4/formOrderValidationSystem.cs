using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ComptMaelSystemV4
{
    public partial class formOrderValidationSystem : Form
    {

        public formOrderValidationSystem()
        {
            InitializeComponent();


        }

    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CreateValTable_Click(object sender, EventArgs e)
        {
            string orderDate = txtOrderDate.Text;
            bool dateExists = Order.validateDateExists(orderDate);
            
            if (!dateExists)
            {

                MessageBox.Show("The date is not valid.", "Date Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            var orders = Order.retrieveOrdersbyDate(orderDate);
            foreach (var order in orders)
            {
                orderBindingSource.Add(order);
            }




        }

        private void txt_OrderDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void formOrderValidationSystem_Load(object sender, EventArgs e)
        {

        }

        public void tableOrderValidation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            



                
            
     
        
        
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public class DataGridViewExporter
        {
            public static void ExportDataGridViewToCSV(DataGridView dataGridView, string filePath)
            {
                StringBuilder csvContent = new StringBuilder();

                // Adding column headers
                string columns = string.Empty;
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    columns += column.HeaderText + ",";
                }
                columns = columns.Remove(columns.Length - 1, 1); // Remove the last comma
                csvContent.AppendLine(columns);

                // Adding row data
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow) // Skip the new row placeholder
                    {
                        string rowContent = string.Empty;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            rowContent += "\"" + cell.Value?.ToString().Replace("\"", "\"\"") + "\","; // Handle commas and quotes
                        }
                        rowContent = rowContent.Remove(rowContent.Length - 1, 1); // Remove the last comma
                        csvContent.AppendLine(rowContent);
                    }
                }

                // Writing to file
                File.WriteAllText(filePath, csvContent.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "export.csv";
                DataGridViewExporter.ExportDataGridViewToCSV(dataGridView1, filePath);
                MessageBox.Show("Data exported successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new ModulePage().Show();
            this.Close();
        }
    }
}

