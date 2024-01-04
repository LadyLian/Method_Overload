using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload
{
    internal class CreditCard
    {
        public double Sum { get; set; }
        public static CreditCard operator +(CreditCard sum1, CreditCard sum2)
        {
            return new CreditCard { Sum = sum1.Sum + sum2.Sum };
        }
        public static CreditCard operator -(CreditCard sum1, CreditCard sum2)
        {
            return new CreditCard { Sum = sum1.Sum - sum2.Sum };
        }
        public static bool operator >(CreditCard sum1, CreditCard sum2)
        {
            return sum1.Sum > sum2.Sum;
        }
        public static bool operator <(CreditCard sum1, CreditCard sum2)
        {
            return sum1.Sum < sum2.Sum;
        }
        public static CreditCard operator ++(CreditCard sum1)
        {
            return new CreditCard { Sum = sum1.Sum + 20 };
        }
        public static bool operator true(CreditCard sum1)
        {
            return sum1.Sum != 0;
        }
        public static bool operator false(CreditCard sum1)
        {
            return sum1.Sum == 0;
        }
        public static bool operator !(CreditCard sum1)
        {
            return sum1.Sum == 0;
        }
    }
}
