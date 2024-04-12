using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banknote
{
    internal static  class Class1
    {
        private static int[] denom = { 1, 2, 5, 10, 100,200, 1000, 2000, 5000, 10000 };
        public static int  Sum(int numbills,int denom )
        {
            return denom * numbills;    
        }
        public static bool check(int arg)
        {
            return denom.Contains(arg);

        }
    }
}
