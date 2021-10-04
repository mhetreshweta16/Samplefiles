using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sub();
            Console.ReadLine();

        }
        public static void Sub()
        {
            Console.WriteLine("hellow sub");
            Console.WriteLine("modify at local");

            Console.WriteLine("hiii , hello , this is changes in local");

            Console.WriteLine("hello everyone . this is changes at remote level ");
            

        }

    }
}
