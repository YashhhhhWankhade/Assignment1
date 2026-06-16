using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x++ + x++ + ++x);
        }
        // Output 
        // 34
    }
}
