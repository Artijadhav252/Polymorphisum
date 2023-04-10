using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisum
{
    internal class child:parent
    {
        //method overloding
        public void show(int num1)
        {
            Console.WriteLine("Child class show method");
        }

        //method  overriding
        public override void display()
        {
            Console.WriteLine("child class display method");
        }
    }
}
