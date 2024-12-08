using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    string conString = "Server=localhost;Database=C20B2;Trusted_Connection=True;MultipleActiveResultSets=true";

        //    List<Customer> cust = new();

        //    using (SqlConnection conn = new SqlConnection(conString))
        //    {
        //        string query = "select * from Customer";
        //        SqlCommand cmd = new SqlCommand(query, conn);

        //        conn.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            cust.Add(new Customer
        //            {
        //                Id = (int)reader["Id"],
        //                Name = (string)reader["Name"],
        //                Age = (int)reader["Age"],
        //                Address = (string)reader["Address"],

        //            });
        //        }
        //    }
            
        //    return View(cust);
        //}
        [HttpGet]
        public IActionResult Index()
        {
            string conString = "Server=localhost;Database=C20B2;Trusted_Connection=True;MultipleActiveResultSets=true";

            List<Customer> cust = new();

            using (SqlConnection conn = new SqlConnection(conString))
            {
                //string query = "select * from Customer";
                SqlCommand cmd = new SqlCommand("sp_GetCustomerRecords", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cust.Add(new Customer
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Age = (int)reader["Age"],
                        Address = (string)reader["Address"],

                    });
                }
            }

            return View(cust);
        }

        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            string conString = "Server=localhost;Database=C20B2;Trusted_Connection=True;MultipleActiveResultSets=true";

            List<Customer> cust = new();
            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "INSERT INTO Customer (Name, Age, Address) VALUES (@parameter1, @parameter2, @parameter3)";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@parameter1", customer.Name);
                cmd.Parameters.AddWithValue("@parameter2", customer.Age);
                cmd.Parameters.AddWithValue("@parameter3", customer.Address);

                conn.Open();
                
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
