using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    internal class Program
    {
        static void xuat()
        {
            Console.WriteLine("tan 1");
        }
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                xuat();
            }
            Console.WriteLine("hung dep trai");
        }
    }
}
