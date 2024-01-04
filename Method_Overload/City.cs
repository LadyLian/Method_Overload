using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload
{
    internal class City
    {
        public int Residents { get; set; }
        public static City operator +(City residents1, City residents2)
        {
            return new City { Residents = residents1.Residents + residents2.Residents };
        }
        public static City operator -(City residents1, City residents2)
        {
            return new City { Residents = residents1.Residents - residents2.Residents };
        }
        public static bool operator >(City residents1, City residents2)
        {
            return residents1.Residents>residents2.Residents;
        }
        public static bool operator <(City residents1, City residents2)
        {
            return residents1.Residents < residents2.Residents;
        }
        public static City operator ++(City residents1)
        {
            return new City { Residents = residents1.Residents + 20 };
        }
        public static bool operator true(City residents1)
        {
            return residents1.Residents != 0;
        }
        public static bool operator false(City residents1)
        {
            return residents1.Residents == 0;
        }
        public static bool operator !(City residents1)
        {
            return residents1.Residents == 0;
        }

    }
}
