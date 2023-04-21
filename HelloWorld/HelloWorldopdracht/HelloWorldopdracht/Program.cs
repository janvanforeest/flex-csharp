using System;
using System.Threading;

namespace HelloWorldopdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = "Hello World!";
            
            foreach(char a in b)
            {
                
                Console.Write(a);
                Thread.Sleep(100);
            }
            Console.ReadLine();
        }
    }
}
