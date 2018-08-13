using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEx
{
    public static class StringEx
    {
        public static string Test(this string data)
        {
            // ReSharper disable once RedundantAssignment
            Console.WriteLine("Success");
            return data + " test";
        }
    }
}
