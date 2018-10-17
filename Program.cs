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
            printOutPut(20);
        }

        private static void printOutPut(int max) {
            
            int[] arr;
            ArrayList odd = new ArrayList();
            ArrayList even = new ArrayList();

            arr = SquaredNums(max);
            odd = OddNums(arr);
            even = EvenNums(arr);
            Console.WriteLine("______Odd numbers______");
            printNum(odd);
            Console.WriteLine("______Even numbers______");
            printNum(even);

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Amount of Numbers (Odd): " + AmountOfNumbers(odd) + " ");
            Console.WriteLine("Amount of Numbers (Even): " + AmountOfNumbers(even) + " ");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Total (Odd): " + Total(odd) + " ");
            Console.WriteLine("Total (Even): " + Total(even) + " ");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Total (Odd): " + Average(odd) + " ");
            Console.WriteLine("Total (Even): " + Average(even) + " ");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Minimum (Odd): " + Minimum(odd) + " ");
            Console.WriteLine("Minimum (Even): " + Minimum(even) + " ");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Maximum (Odd): " + Maximum(odd) + " ");
            Console.WriteLine("Maximum (Even): " + Maximum(even) + " ");
            Console.WriteLine("------------------------------------------------------------------");
            
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

        public static int AmountOfNumbers(ArrayList arr) {
            int count = 0;
            for (int i = 0; i < arr.Count;i++)
            {
                count++;
            }
            return count;
        }//end amount of numbers

        public static int Total(ArrayList arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sum += (int)arr[i];
            }
            return sum;
        }//ends total method

        //average method
        public static double Average(ArrayList arr)
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

        public static int Minimum(ArrayList arr)
        {
            int low = 0;
            if(arr.Count>0){//ensures count is greater than o
            low=(int)arr[0];//initialize lowest with first number in arrayList
            for (int i = 0; i < arr.Count;i++ )
                {
                    if((int)arr[i]<low){
                        low = (int)arr[i];//new lowest number
                    }
                }
            
            }
            return low;
        }//ends method

        public static int Maximum(ArrayList arr)//method find highest number in arrayList
        {
            int high = 0;
            if (arr.Count > 0)
            {//ensures count is greater than o
                high = (int)arr[0];//initialize lowest with first number in arrayList
                for (int i = 0; i < arr.Count; i++)
                {
                    if ((int)arr[i] > high)
                    {
                        high = (int)arr[i];//new lowest number
                    }
                }

            }
            return high;
        }//ends maximum method


        //printing output
        public static void printNum(ArrayList arr) {
            //printing
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        
        }

    }
}
