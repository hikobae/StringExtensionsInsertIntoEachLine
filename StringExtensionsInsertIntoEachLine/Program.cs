using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionsInsertIntoEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("abc\n1".InsertIntoEachLine(0, "1"));
        }
    }
}
