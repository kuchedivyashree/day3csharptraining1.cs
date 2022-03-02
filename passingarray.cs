using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class passingarray
    {
        static void Result(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("array elements: " + arr[i]);
            }
        }

        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Result(arr);
            Console.ReadLine();
        }
    }
}
