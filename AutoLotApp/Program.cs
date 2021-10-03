using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (AutoLotConnection connection = new AutoLotConnection())
            {
                //Console.WriteLine("Customers");
                //Console.WriteLine("CustId    FirstName    LastName    ");
                //foreach (var item in connection.Customers)
                //{
                //    Console.WriteLine(item.CustId+ "   " + item.FirstName + "    " + item.LastName);
                //}
                Console.WriteLine(connection.Database.Connection.ConnectionString);
                SqlConnectionStringBuilder s = new SqlConnectionStringBuilder(connection.Database.Connection.ConnectionString);
                Console.WriteLine(s.AttachDBFilename);
                Console.ReadKey();
                Console.WriteLine("Invertory");
                Console.WriteLine("CarId   Make   Color   PetName");
                connection.Invertories.Add(new Invertory() { CarId = 3, Make = "Chevrolet", Color = "Black", PetName = "" });
                connection.SaveChanges();
                foreach (var item in connection.Invertories)
                {
                    Console.Write(1 + "   ");
                    Console.WriteLine(item.CarId+"    " + item.Make+ "    " + item.Color + "     " + item.PetName);
                }
                Console.WriteLine("end");
                //Console.WriteLine("Orders");
                //Console.WriteLine("OrderId   CarId   CustId");
                //foreach (var item in connection.Orders)
                //{
                //    Console.WriteLine(item.OrderId+"       "+item.CarId+"     "+item.CustId);
                //}
            }
            Console.ReadKey();
        }
    }
}
