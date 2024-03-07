using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Genericss
{
    public class MaximumI
    { 

        public void maxArr<T>(T[] arr) where T : IComparable<T>
        { 

         var  max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            { 
                
                if (max.CompareTo(arr[i]) < 0)
                {
                    max = arr[i];
                }

            }
            Console.WriteLine(max);
        }



    }
}
