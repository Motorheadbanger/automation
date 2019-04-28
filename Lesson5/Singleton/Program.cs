using System;

namespace Singleton
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.getInstance() == Singleton.getInstance());
            Console.ReadKey();
        }
    }
}
