using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisum
{
    internal class Arithmetic
    {
        //public void add(int num1 , int num2)
        //{
        //    int result = num1 + num2;
        //    Console.WriteLine("Addition of two numbers:"+result);

        //}
        //public void add(float num1, float num2)
        //{
        //    float result = num1 + num2;
        //    Console.WriteLine("Addition of two float:"+result);

        //}
        //public void add(int num1,float num2)
        //{
        //    float result = num1 + num2;
        //    Console.WriteLine("Addition of one float ane one integer:"+result);
        //}
        //public void add(int num1 , int num2 ,int num3)
        //{
        //    int result = num1 + num2 + num3;
        //    Console.WriteLine("addition of three integer number:"+result);


        //}


        //public void sub(int num1,int num2)
        //{
        //    int result = num1 - num2;
        //    Console.WriteLine("substraction of two number:"+result);
        //}
        //public void sub(int num1,float num2)
        //{
        //    float result = num1 - num2;
        //    Console.WriteLine("substractration of one float one integer:"+result);
        //}
        //public void sub(int num1,int num2,int num3)
        //{
        //    int result = num1 + num2 + num3;
        //    Console.WriteLine("substraction of three integer:"+result);
        //}
        //public void sub(float num1,float num2)
        //{
        //    float result = num1 - num2;
        //    Console.WriteLine("Substraction of two float number");
        //}
        public void mul(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("multiplication of two integer:"+result);
        }
        public void mul(int num1,float num2)
        {
            float result = num1 + num2;
            Console.WriteLine("multiplication one integer and one float: "+result);
        }
        public void mul(int num1,int num2,float num3)
        {
            float result = num1 + num2 + num3;
            Console.WriteLine("multiplication of two integer and one float:"+result);
        }

    }
}
