using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericss
{
    internal class StringMax
    {


        String[] maxArr = { "hii","hello", "hellobro", "howareyou", "abcd" };




        public void strArr()
        {
            int[] arr1=new int[maxArr.Length];
          
            int j = 0;
            for (int i=0;i<maxArr.Length;i++)
            {
                arr1[j] = maxArr[i].Length;
                j++;
            }

            int max1 = arr1[0];
 
            int temp1=0;
            for(int i = 0; i < arr1.Length; i++)
            {
                if (max1 < arr1[i])
                {
                    max1 = arr1[i];
                    temp1 = i;

                    
                }

            }
            Console.WriteLine("Max String LENGTH "+max1);
            Console.WriteLine("Max String Index "+temp1);

            for(int i=0;i<maxArr.Length;i++)

            {
                if (i == temp1)
                {
                    Console.WriteLine(maxArr[temp1]);
                   
                }
               


            }

        }
    }
}
