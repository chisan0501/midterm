using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_KaManMak
{
    class President : Employee
    {
        public President(int id, string last, string first, DateTime dob, DateTime hire, decimal salary) : base(id, last, first, dob, hire, salary)
        {

        }

        private int _car_allowance;
        public int car_allowance
        {
            get
            {
                return _car_allowance;
            }
            set
            {
                _car_allowance = value;
            }
        }

        //holds numbre of sales for division
        private int _number_of_sales;
        public int number_of_sales
        {
            get
            {
                return _number_of_sales;
            }
            set
            {
                _number_of_sales = value;
            }
        }

        private int _SalesBonus;
        public int SalesBonus(int number_of_sales)
        {
            int bonus = 0;
            if (number_of_sales > 10 && number_of_sales < 20)
            {

                bonus = 5;
            }
            else if (number_of_sales > 20 && number_of_sales < 30)
            {

                bonus = 10;
            }
            else if (number_of_sales > 30)
            {

                bonus = 20;
            }
            return bonus;
        }


    }
}
