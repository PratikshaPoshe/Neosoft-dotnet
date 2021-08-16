using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team3_Keywords
{
    class ThisKeyword
    {
        public string Name;

        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public ThisKeyword() : this("This Keyword")
        {
            Console.WriteLine("Non-Parameter Constructer Called");
        }

        public ThisKeyword(string Name)
        {
            Console.WriteLine("Parameter Constructer Called");
        }

        public void display()
        {
            this.show();
            Console.WriteLine("Inside display function");
        }

        public void show()
        {
            Console.WriteLine("Inside show funcion");
        }

        void show_display(ThisKeyword obj)
        {
            int a = 10, b = 20;
            Console.WriteLine("a = " + a + " b = " + b);
        }

        public void get()
        {
            show_display(this);
        }

        private string[] days = new string[7];

        public string this[int index]
        {
            get
            {
                return days[index];
            }

            set
            {
                days[index] = value;
            }
        }

    }
}
