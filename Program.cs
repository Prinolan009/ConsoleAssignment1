using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            /*ArrayList arr= OddNums(SquaredNums(20));
            for(int i=0;i<arr.Count;i++){
            Console.WriteLine(arr[i]);
            }
            Console.ReadLine();*/
            for (int i = 0; i < SquaredNums(20).Length; i++)
            {
                Console.WriteLine(SquaredNums(20)[i]);
            }
            Console.ReadLine();
        }

        private static int[] SquaredNums(int MaxNumber) {
            int[] arr = new int[MaxNumber];
            for (int i = 1; i <= MaxNumber;i++ )
            {
                arr[i-1] = i * i;//squaring number and storing to array
            }
            return arr;
        }//ends method

        private static ArrayList OddNums(int [] arr) {
            ArrayList Odd=new ArrayList();
            for (int i = 0; i < arr.Length;i++)
            {
                if(arr[i]%2==1){
                Odd.Add(arr[i]);

                }
            }
            return Odd;
        }
    }
}
