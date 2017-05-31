using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            int[] angka1 = {5, 1, 2, 4, 9, 3, 4};
            int count = 0;
            for (int i = 0 ; i < angka1.Length; i++)
            {   
                
                if(angka1[i] %2 == 1)
                {
                    int temp = angka1[i];
                    int[] temp2 = new int[];
                    count++;
                   // Console.WriteLine(temp);
                    
                    Array.Sort(temp2);
                    Console.WriteLine(temp2[0]);
                }
                
                
            }
            //Console.WriteLine(angka1.Length);

        }

    }

}
           





          
