using static System.Console;
using static System.Convert;
using System.Collections.Generic;

namespace Demo_Assign2
{
    class AutoInit
    {
        public int num { get; }=1000;
        // public AutoInit()
        // {
        //     num = 1000;
        // }
    }
    class Dict
    {
        internal static void MyDict() {
            Dictionary<int, string> _Dict = new Dictionary<int, string>()
            {
                {1,"Red" },
                {2,"Blue" },
                {3,"Green" },
                {4,"Yellow" },
                {5,"Black" }
            };
            foreach(var item in _Dict)
            {
                Write(item.Key+item.Value + "\t");
            }
            //{
            //    [0] = "Red",    
            //    [1] = "Blue",
            //    [2] = "Green",
            //    [3] = "Yellow",
            //    [4] = "Black"
            // };
    } 
}
    class Employee
    {
        public int Id { get; set; } = 101;
        public string Name { get; set; } = "Nicole";
        public string Location { get; set; } = "Los Angles";
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            Dict.MyDict();

            Employee e = new Employee();
            WriteLine("n\n\n\n\n");
            WriteLine("Name"+e.Name);
            WriteLine("Id" + e.Id);
            WriteLine("Location" + e.Location);
            WriteLine("\n\n");
            WriteLine(nameof(e.Name)+e.Name);
            WriteLine(nameof(e.Id) + e.Id);
            WriteLine(nameof(e.Location) + e.Location);
            
            Write("Enter a  number: ");
            int num = Convert.ToInt32(ReadLine());
            WriteLine($"num is {num}");
        }
    }
}
