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
<<<<<<< HEAD
            Console.WriteLine("hiii , hello , this is changes in local");
=======
            Console.WriteLine("hello everyone . this is changes at remote level ");
            
>>>>>>> 020173c46e5f809cded3e2871c23892e47e261b4
        }

    }
}
