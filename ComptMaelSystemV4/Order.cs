﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;
namespace ComptMaelSystemV4
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string OrderDate { get; set; }
        public bool IsCustomized { get; set; }
        public string OrderItems { get; set; }
        public string Quantity { get; set; }

        public bool CheckOrderDateExists(string filePath, string orderDate)
        {
            var lines = File.ReadAllLines(filePath).Skip(1); // Skip the header row

            foreach (var line in lines)
            {
                // Split line into columns, assuming there are no commas in the quoted text
                var columns = line.Split(',');
                var currentOrderDate = columns[2].Trim('"').Trim(); // Trimming potential quotes and whitespace

                if (currentOrderDate == orderDate)
                {
                    return true; // The order date exists in the file
                }
            }
            // If we reach this point, the order date was not found
            return false;

            
        }

        public static List<Order> retrieveOrdersbyDate(string orderDate)
        {
            string filePath = @"Orders.csv";

            var orders = new List<Order>();
            var lines = File.ReadAllLines(filePath).Skip(1); // Skip header

            foreach (var line in lines)
            {
                // This regex will match commas that are not inside quotes
                var columns = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

                // Further processing to trim quotes from each column
                for (int i = 0; i < columns.Length; i++)
                {
                    columns[i] = columns[i].TrimStart('"').TrimEnd('"').Trim();
                }

                if (columns[2] == orderDate) // Assuming the third column is OrderDate
                {
                    orders.Add(new Order
                    {
                        OrderID = int.Parse(columns[0]),
                        CustomerID = int.Parse(columns[1]),
                        OrderDate = columns[2],
                        IsCustomized = bool.Parse(columns[3]),
                        // Assuming that OrderItems is the fifth column and Quantity is right after OrderItems
                        OrderItems = columns[4],
                        // Since Quantity is a comma-separated list in the same cell as OrderItems,
                        // we take the last part of the OrderItems column as Quantity
                        Quantity = columns.Length > 5 ? columns[5] : ""
                    });
                }
            }

            return orders;
        }
        public void DisplayOrderData(DataGridView dataGridView, Order order)
        {
           
            

          
            


        }
    }
}