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
            report(0);
        }

        public static void report(int employee_id)
        {
            
            data.get_employee(employee_id);
        }

    }
}
