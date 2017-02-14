using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_KaManMak
{
    class Sales_Associate : Employee
    {
        public Sales_Associate(int id, string last, string first, DateTime dob, DateTime hire, decimal salary, double bonus_percent) : base(id, last, first, dob, hire, salary)
        {
            this._bonus_percent = bonus_percent;
        }

        private int _SalesTotal;
        public int SalesTotal
        {
            get
            {
                return _SalesTotal;
            }

            set
            {
                _SalesTotal = value;
            }
        }

        private double _bonus_percent;
        public double bonus_percent
        {
            get
            {
                return _bonus_percent;
            }
            set
            {
                _bonus_percent = value;
            }
        }
    }
}
