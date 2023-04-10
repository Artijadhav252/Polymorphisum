using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisum
{
    internal class parent
    {
        public void show()
        {
            Console.WriteLine("Parent class show method");
        }
        public virtual void display()
        {
            Console.WriteLine("parent class display method");
        }
    }
}
