using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_KaManMak
{
    class Sales_Manager : Employee
    {

        public Sales_Manager() : base(0,"","","",DateTime.MinValue,DateTime.MinValue,100)
        {

        }

        public Sales_Manager(int id, string job,string last, string first, DateTime dob, DateTime hire, decimal salary,int car_allowance,string totalSalles) : base(id, job,last, first, dob, hire, salary)
        {
            this._car_allowance = car_allowance;
            
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

        //get total number of sales from department, 
        //for now ,we assume all sales are done with same department
        public int get_dept_sales()
        {
            int result = 0;

            var data = new data_provider();
            result = data.get_sales_total();

            return result;
        }

       
        public int number_of_sales
        {
            get
            {
                return get_dept_sales();
            }
            set{ }
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
