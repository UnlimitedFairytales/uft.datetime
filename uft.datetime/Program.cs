using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uft.datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = DateTime.Now;
            if (args != null && 0 < args.Length)
            {
                result = result.AddYears(int.Parse(args[0]));
            }
            if (args != null && 1 < args.Length)
            {
                result = result.AddMonths(int.Parse(args[1]));
            }
            if (args != null && 2 < args.Length)
            {
                result = result.AddDays(int.Parse(args[2]));
            }
            if (args != null && 3 < args.Length)
            {
                result = result.AddHours(int.Parse(args[3]));
            }
            if (args != null && 4 < args.Length)
            {
                result = result.AddMinutes(int.Parse(args[4]));
            }
            if (args != null && 5 < args.Length)
            {
                result = result.AddSeconds(int.Parse(args[5]));
            }
            Console.WriteLine(result);
        }
    }
}
