using System;

class Program
{
    static void Main(string[] args)
    {
        Singleton obj1 = Singleton.GetInstance();
        Singleton obj2 = Singleton.GetInstance();

        if (obj1 == obj2)
        {
            Console.WriteLine("Singleton works! Both objects are the same instance.");
        }

        Console.ReadLine();
    }
}
