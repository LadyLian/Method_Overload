using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        
        public static Employee operator +(Employee sum1, Employee sum2)
        {
            return new Employee { Salary = sum1.Salary + sum2.Salary };
        }
        public static Employee operator -(Employee sum1, Employee sum2)
        {
            return new Employee { Salary = sum1.Salary - sum2.Salary };
        }
        public static bool operator >(Employee sum1, Employee sum2)
        {
            return sum1.Salary > sum2.Salary;
        }
        public static bool operator <(Employee sum1, Employee sum2)
        {
            return sum1.Salary < sum2.Salary;
        }
        public static Employee operator ++(Employee sum1)
        {
            return new Employee { Salary = sum1.Salary + 20 };
        }
        public static bool operator true(Employee sum1) {
            return sum1.Salary != 0;
        }
        public static bool operator false(Employee sum1)
        {
            return sum1.Salary == 0;
        }
        public static bool operator !(Employee sum1)
        {
            return sum1.Salary == 0;
        }
    }
}
