using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericss
{
    internal class PrintArray
    {

        int[] intArr = { 1, 2, 3, 4, 5 };

        float[] floatArr = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };

        Char[] charArr = { 'a', 'b', 'c', 'd', 'e', 'f' };


        
       public void intArray()
        {
            for(int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i] + " ");
            }
            Console.WriteLine();
        }

        public void floatArray()
        {
            for(int i = 0; i < floatArr.Length; i++)
            {
                Console.Write(floatArr[i] + " ");
            }
            Console.WriteLine();
        }

        public void charArray()
        {
            for(int i = 0; i < charArr.Length; i++)
            {
                Console.Write(charArr[i] +" ");
            }
            Console.WriteLine();
        }
    }
}
