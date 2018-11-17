using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Program:EncoderFallback
    {
        static void Main(string[] args)
        {
            Tshirt ob = new Tshirt();
            ob.Discount();
            Console.ReadLine();
        }
    }
}
