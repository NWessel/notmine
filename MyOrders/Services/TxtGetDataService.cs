using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyOrders.DTO;
using MyOrders.Data;
using MyOrders.Models;
using MyOrders.Services.Interfaces;
using System.IO;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Data.Sqlite;

namespace MyOrders.Services
{
    public class TxtGetDataService : IGetDataService
    {
        private readonly OrderContext _context;


        public TxtGetDataService(OrderContext context)
        {
            _context = context;
        }
        public List<Order> ImportData()
        {
            List<Order> orders = new List<Order>();
            try
            {
                string[] files = Directory.GetFiles(@"app_data");

                

                foreach (string file in files)
                {
                    List<string> lines = File.ReadAllLines(file).Skip(1).ToList();

                    foreach (var line in lines)
                    {
                        string[] entries = line.Split("|");

                        if (!String.IsNullOrEmpty(entries[1]))
                        {
                            Order newOrder = new Order();

                            // REVIEW: change try blocks
                            try
                            {
                                newOrder.OrderNumber = ConvertStringToInt(entries[1]);
                                newOrder.OrderDate = ConvertStringToDate(entries[9]);
                                newOrder.Customer.CustomerName = entries[10];
                                newOrder.Customer.CustomerNumber = ConvertStringToInt(entries[11]);
    
                                foreach (var productOrder in newOrder.OrderProduct)
                                {
                                    productOrder.OrderLineNumber = ConvertStringToInt(entries[2]);
                                    productOrder.Quantity = ConvertStringToInt(entries[4]);
                                    productOrder.Product.Name = entries[5];
                                    productOrder.Product.Description = entries[6];
                                    productOrder.Product.Price = ConvertStringToInt(entries[7]);
                                    productOrder.Product.ProductGroup.ProductGroup = entries[8];
                                }
                            }
                            catch (System.Exception)
                            {
                                
                                throw;
                            }

                            orders.Add(newOrder);
                        }
                    }

                    // using (var transaction = _context.BeginTransaction())
                    // {
                    //     using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                    //     {
                    //         //Set the database table name
                    //         sqlBulkCopy.DestinationTableName = "[dbo].[test2]";
                    //         con.Open();
                    //         sqlBulkCopy.WriteToServer(dt);
                    //         con.Close();
                    //     }
                    // }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            return orders;
        }

        // TODO: move these out and use in Controller's Detail section
        public int ConvertStringToInt(string stringNum)
        {
            bool isIntValid = int.TryParse(stringNum, out int num);
            if (!isIntValid)
            {
                throw new ArgumentOutOfRangeException();
            }

            return num;
        }
        public DateTime ConvertStringToDate(string stringDate)
        {
            bool isDateValid = DateTime.TryParse(stringDate, out DateTime date);
            if (!isDateValid)
            {
                throw new ArgumentOutOfRangeException();
            }

            return date;
        }
    }
}