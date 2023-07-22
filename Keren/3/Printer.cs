using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keren._3
{
    internal class Printer<T> where T : IPrintable
    {
        public void Print(T printable)
        {
            string print = printable.getPrint();
            Console.WriteLine(print);
        }
    }
}
