using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_KaManMak
{
    class programmer : Employee
    {
        public programmer(int id, string job,string last, string first, DateTime dob, DateTime hire, decimal salary) : base(id, job, last, first, dob, hire, salary)
        {

        }
    }
}
