/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Threading.Tasks;
namespace TaskExample
{
public static class TaskProgram
 {
    public static void Main()
        {
            Task t = Task.Run(() =>

            {
            for (int x = 0; x < 50; x++)
            {
            Console.Write("Hi ");
            }
            });
            t.Wait();
        }
  }
}
