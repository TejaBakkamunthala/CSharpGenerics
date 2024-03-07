using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Genericss.GenericPrintArray;


namespace Genericss
{
    public class Program
    {
        static void Main(string[] args)
        {



            /*  PrintArray pa = new PrintArray();
              pa.intArray();
              pa.floatArray();
              pa.charArray();

              Console.ReadKey();*/



            //GenericPrintArray gpa = new GenericPrintArray();

            //int[] intArr = { 1, 2, 3, 4, 5 };
            //gpa.genericDemo<int>(intArr);

            //float[] floatArr = { 1.2f, 2.3f, 3.4f, 4.5f };
            //gpa.genericDemo<float>(floatArr);

            //char[] charArr = { 'a', 'b', 'c', 'd', 'e' };
            //gpa.genericDemo(charArr);
            //Console.ReadKey();



            //3rd Progarm
            //MaximumI mi = new MaximumI();

            //int[] arr = { 10, 30, 40, 20, 100, 90, 60 };
            //mi.maxArr<int>(arr);


            //float[] arr1 = { 10.2f, 30.3f, 40.4f, 20.4f, 100.5f, 90.6f, 60.5f };
            //mi.maxArr<float>(arr1);

            //string[] arr2 = { "hii", "hello", "haow are you" };
            //mi.maxArr<string>(arr2);

            //StringMax sm = new StringMax();
            //sm.strArr();
            //Console.ReadKey();



           GenericClass<string> g1=new GenericClass<String>("This is String Generic Class");
            GenericClass<int> g2 = new GenericClass<int>(101);
            GenericClass<float> g3 = new GenericClass<float>(2.34f);

        //   Console.WriteLine(g1);
        //    Console.WriteLine(g2);
        //    Console.WriteLine(g3);

            Console.ReadKey();




        }
    }
}
