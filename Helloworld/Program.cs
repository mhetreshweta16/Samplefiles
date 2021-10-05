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
<<<<<<< HEAD
            Console.WriteLine("hiii , hello , this is changes in local");
            Console.WriteLine("hello everyone . this is changes at remote level ");
            Console.WriteLine("hello everyone . this is changes at remote level ");
            

=======

            Console.WriteLine("hello everyone . this is changes at remote level ");
            


            Console.WriteLine("modify the code at remote");

>>>>>>> 1b41d97fb218c33c619a82cd728b0f905c20c305
        }

    }
}
