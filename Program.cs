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
           
            
        }

        private static int[] SquaredNums(int MaxNumber) {
            int[] arr = new int[MaxNumber];
            for (int i = 1; i <= MaxNumber;i++ )
            {
                arr[i-1] = i * i;//squaring number and storing to array
            }
            return arr;
        }//ends method

        //method used to get Odd numbers
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

        //method used to get even numbers
        private static ArrayList EvenNums(int[] arr)
        {
            ArrayList Even = new ArrayList();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Even.Add(arr[i]);
                }
            }
            return Even;
        }

        //void method for printing out 

        public int AmountOfNumbers(ArrayList arr) {
            int count = 0;
            for (int i = 0; i < arr.Count;i++)
            {
                count++;
            }
            return count;
        }//end amount of numbers

        public int Total(ArrayList  arr) {
            int sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sum += (int)arr[i];
            }
            return sum;
        }//ends total method

        //average method
        public double Average(ArrayList arr)
        {
            double avg = 0;
            int sum = 0;
            for (int i = 0; i < arr.Count;i++ )
            {
                sum += (int)arr[i];
            }

             avg=(sum/arr.Count);
             return avg;
        }//ends method

        public int Minimum(ArrayList arr)
        { 
        
        }

        public int Maximum(ArrayList arr)
        { 
        
        }
    }
}
