using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_KaManMak
{
    class data_provider
    {
        public static string connection_string = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        private static SqlConnection sqlConnection = new SqlConnection(connection_string);
        public data_provider()
        {


        }


        public int get_sales_total()
        {
            int result = 0;

            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                OpenConnection();
                try
                {
                    string sql = "SELECT SalesTotal FROM Sales";
                    SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        result += int.Parse(dr["SalesTotal"].ToString());

                    }
                    dr.Close();

                }
                catch (SqlException ex)
                {
                    // Display error
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }

            return result;
        }

        public Employee get_employee(int employee_id)
        {
            Employee result = new Employee();
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                OpenConnection();
                try
                {
                    // Sql Select Query 
                    string sql = "SELECT * FROM Employee where Id =" + employee_id;
                    SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        dr["Id"].ToString();
                        dr["firstName"].ToString();
                        
                        dr["jobTitle"].ToString();
                        var hire = DateTime.Parse(dr["HireDate"].ToString());
                        var DOB = DateTime.Parse( dr["DOB"].ToString());
                        var salary = decimal.Parse(dr["salary"].ToString());
                        result = new Employee(employee_id, dr["jobTitle"].ToString(),dr["lastName"].ToString(), dr["firstName"].ToString(),DOB,hire, salary);
                    }
                    dr.Close();
                  
                }
                catch (SqlException ex)
                {
                    // Display error
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }

                



            return result;
        }
        private static void OpenConnection()
        {
            try
            {
                // Open Connection
                sqlConnection.Open();
                Console.WriteLine("Connection Opened");
            }
            catch (SqlException ex)
            {
                // Display error
                Console.WriteLine("Error: " + ex.ToString());
            }
        }

    }
}





