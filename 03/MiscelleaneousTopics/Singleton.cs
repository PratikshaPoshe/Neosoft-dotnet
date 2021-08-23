using System;
namespace MiscelleaneousTopics
{
    public sealed class Singleton
    {
        private static int counter =0;
        private static readonly Lazy<Singleton> instance=new Lazy<Singleton>(()=>new Singleton());
        private Singleton()
        {
           counter++;
           Console.WriteLine(counter); 
        }
        public static Singleton getInstance { 
            get{
                return instance.Value;
            }
         }
    }
}