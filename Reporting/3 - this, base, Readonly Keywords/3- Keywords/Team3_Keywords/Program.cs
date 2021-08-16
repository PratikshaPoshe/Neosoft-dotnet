using System;

namespace Team3_Keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Base Keyword---------------\n");
            Giraffe g = new Giraffe();
            Console.WriteLine();
            Console.WriteLine();
            Tiger t = new Tiger(7);
            Console.WriteLine();
            Console.WriteLine();
            g.show();
            Console.WriteLine();
            t.show();

            Console.WriteLine("\n");
            Console.WriteLine("---------------Const Keyword---------------\n");
            const int a = 10;
            const int b = 20;
            const int c = b + a;
            Console.WriteLine("The value of c is: "+c);

            Console.WriteLine("\n");
            Console.WriteLine("---------------Readonly Keyword---------------\n");
            ReadonlyKeyword ob = new ReadonlyKeyword("welcome", "neosoft");

            Console.WriteLine("\n");
            Console.WriteLine("---------------This Keyword---------------\n");
            ThisKeyword obj = new ThisKeyword();
            obj.SetName("C# programming");
            Console.WriteLine(obj.GetName());

            obj.display();

            obj.get();

            obj[0] = "Sun";
            obj[1] = "Mon";
            obj[2] = "Tue";
            obj[3] = "Wed";
            obj[4] = "Thu";
            obj[5] = "Fri";
            obj[6] = "Sat";
            for (int i = 0; i < 7; i++)
                Console.Write(obj[i] + " ");

            Console.ReadLine();
        }
    }
}
