using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team3_Keywords
{
    class AnimalZoo
    {
        public AnimalZoo()
        {
            Console.WriteLine("We have giraffe's too in our zoo");
        }
        public AnimalZoo(int i)
        {
            Console.WriteLine($"There are {i} tigers in the zoo");
        }
        public virtual void show()
        {
            Console.WriteLine("*****Welcome to Hooves Petting Zoo*****");
        }
    }

    class Tiger : AnimalZoo
    {
        public Tiger(int i) : base(i)
        {
            int a = i + 2;
            Console.WriteLine($"Now we are {a} tigers in the zoo");
        }
        public override void show()
        {
            base.show();
            Console.WriteLine("We tigers belong to hooves petting zoo");
        }
    }
    class Giraffe : AnimalZoo
    {
        public Giraffe()
        {
            Console.WriteLine("We Giraffe's are happy together in the zoo");
        }
        public override void show()
        {
            base.show();
            Console.WriteLine("We giraffes also belong to hooves petting zoo");
        }
    }
}
