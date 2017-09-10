using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_27
{
    class Program
    {
        static void Main(string[] args)
        {
            LazyItem <DateTime> LI = new LazyItem<DateTime>(Func);
            Console.WriteLine(LI.Item);
            Console.WriteLine(LI.Item);
            Console.ReadKey(true);
        }
        static DateTime Func()
        {
            return DateTime.Now;
        }
    }
}
