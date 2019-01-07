using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class ORDER
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public List<ORDER> GetOrders()
        {
            // Veri tabanından order tablosundaki verileri çekip bir liste olarak döndürelim.

            string adres = @"Server = DESKTOP-T79GQPE\SQLEXPRESS; Database = NORTHWND; User Id = Lenova; Integrated Security = true;";
            var sorgu = @"SELECT o.CustomerID,o.EmployeeID,o.OrderID, o.OrderDate,
(SELECT ContactName FROM Customers WHERE CustomerID = o.CustomerID) AS ContactName FROM Orders o";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, adres);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            List<ORDER> liste = new List<ORDER>();
            foreach (DataRow Row in dt.Rows)
            {
                ORDER o = new ORDER();
                o.OrderID = (int)Row["OrderID"];
                o.CustomerID = (string)Row["CustomerID"];
                o.EmployeeID = (int)Row["EmployeeID"];
                o.OrderDate = (DateTime)Row["OrderDate"];
                o.Customer = new Customer();
                o.Customer.ContactName = Row["ContactName"].ToString();
                o.Customer.CustomerID = (string)Row["CustomerID"];
                liste.Add(o);

            }
            return liste;
            
        }
    }

    class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public List<ORDER> Orders { get; set; }
        public int OrderCount
        {
            get
            {
                return Orders.Count;
            }
        }
    }
}
