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
                    
                    List<int> temp2 = new List<int>();

                    temp2.Add(temp);
                    count++;
                    // Console.WriteLine(temp);
                    temp2.Sort();   
                    foreach (int value in temp2)
                    {
                        Console.WriteLine(value);
                    }

                    
                }
                
                
            }
            //Console.WriteLine(angka1.Length);

        }

    }

}
           





          
