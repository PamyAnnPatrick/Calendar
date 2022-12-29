using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_729
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalendar obj = new MyCalendar();
            Console.WriteLine(obj.Book(10, 20));
            Console.WriteLine(obj.Book(15, 25));
            Console.WriteLine(obj.Book(20, 30));
        }
    }
}
