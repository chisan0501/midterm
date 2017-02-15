using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_KaManMak
{
    class Program
    {
        static data_provider data = new data_provider();
        static void Main(string[] args)
        {
         
            report(3);
        }

        public static void report(int employee_id)
        {
           
           var result =  data.get_employee(employee_id);
            string strEmployeeID = "EmployeeID";
            string strJobTitle = "Title";
            string strFirstName = "FirstName";
            string strLastName = "LastName";
            string strDOB = "DOB";
            string strHireDate = "Hire Date";
            string strYear = "Years in Company";
            int jobTitleLength = result.jobTitl.Length; 
           
            Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6}", strEmployeeID.PadRight(10), strJobTitle.PadRight(jobTitleLength), strFirstName.PadRight(10), strLastName.PadRight(10), strDOB.PadRight(10),strHireDate.PadRight(10),strYear.PadRight(10));
            Console.WriteLine("===========================================================================================================");
            Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6}",
                    result.ID.ToString().PadRight(10),
                    result.jobTitl.PadRight(jobTitleLength),
                    result.first_name.PadRight(10),
                    result.last_name.PadRight(10),result.Dob.ToString("yyyy-MM-dd").PadRight(10),result.Hire.ToString("yyyy-MM-dd").PadRight(10),result.years.ToString().PadRight(10));
            

        }

    }
}
