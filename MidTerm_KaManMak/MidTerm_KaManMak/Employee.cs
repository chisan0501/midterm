using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_KaManMak
{
    class Employee
    {
        public Employee() : this(0,"","","",DateTime.MinValue,DateTime.MinValue,10)
        {

        }
        public Employee(int id, string job,string last, string first, DateTime dob, DateTime hire, decimal salary)
        {
            this.ID = id;
            this._last_name = last;
            this._first_name = first;
            this._dob = dob;
            this._hire = hire;
            this._Salary = salary;
            this._jobTitle = job;
           
        }

       

        private int _ID = 0;
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                if (value >= 0)
                {
                    _ID = value;
                }
                else
                {
                    throw new Exception("ID can't be less than 0");

                }
            }
        }

       
       public int years
        {
            get
            {
                return get_years_in_company();
                    
                    
                    }
            set { }
        }


        public int get_years_in_company()
        {
            int result = 0;

            result = DateTime.Now.Year - Hire.Year;

            if ((DateTime.Now.Month < Hire.Month) ||
           ((DateTime.Now.Month == Hire.Month) &&
           (DateTime.Now.Day < Hire.Day)))
            {
                --result;
            }
            return result;

        }


        private string _jobTitle;
        public string jobTitl
        {
            get
            {
                return _jobTitle;
            }
            set
            {
                _jobTitle = value;
            }
        }
        private DateTime _hire = DateTime.MinValue;
        public DateTime Hire
        {
            get
            {
                return _hire;
            }

            set
            {
                if (value >= DateTime.Today)
                {
                    _hire = value;
                }
                else
                {
                    throw new Exception("Invalid Hire Date");

                }
            }
        }


        private decimal _Salary = 0;
        public decimal Salary
        {
            get
            {
                return _Salary;
            }

            set
            {
                if (value >= 0)
                {
                    _Salary = value;
                }
                else
                {
                    throw new Exception("Invalid Salary");
                }
            }
        }
        private DateTime _dob = DateTime.MinValue;
        private string last;
        private string first;

        public DateTime Dob
        {
            get
            {
                return _dob;
            }

            set
            {
                if (value >= DateTime.Today)
                {
                    _dob = value;
                }
                else
                {
                    throw new Exception("Invalid Date of Birth");

                }
            }
        }


        private string _last_name { get; set; } = String.Empty;
        public string last_name
        {
            get
            {
                return _last_name;
            }
            set
            {
                _last_name = value;
            }
        }
        private string _first_name { get; set; } = String.Empty;
        public string first_name
        {
            get
            {
                return _first_name;
            }
            set
            {
                _first_name = value;
            }
        }
    }


  



}
