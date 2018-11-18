using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
  public abstract class TestAbstract
    {
        public virtual void Discount()
        { }

        public void Add()
        {
            Console.WriteLine("This is my normal method");

        }
    }

    public class Tshirt : TestAbstract
    {
        //public override void Discount()
        //{
        //    Console.WriteLine("This is abstract impementation");
            
        //}

    }
}
