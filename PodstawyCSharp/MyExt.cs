using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCSharp
{
    public static class MyExt
    {
        public static decimal ToDecimal(this string l)
        {
            return decimal.Parse(l);
        }


        public static string ToString(this int l, string format ="")
        {
            return "hehe";
        }


    }
}
