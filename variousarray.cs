using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class variousarray
    {
      public static void Main()
        {
            int[] array = new int[] { 1, 9, 6, 7, 5, 9 };

            Array.Sort(array);
            Array.Reverse(array);

            foreach(int value in array)
            {
                Console.Write(value + " ");
                
            }
        }
    }
}
