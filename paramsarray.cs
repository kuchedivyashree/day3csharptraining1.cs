using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class paramsarray
    {
        public static int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
            

        static void Main(string[] args)
        {
            
            int y= AddElements(12,13,10,15,56);

            Console.WriteLine(y);
            Console.ReadLine();
            
        }
    }
    
}
