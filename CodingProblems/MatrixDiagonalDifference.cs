using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    public class MatrixDiagonalDifference
    {
        private static int Size;

        public static void Start()
        {
            
            Console.WriteLine( Compute(getInputs()).ToString());
        }

        private static int[] getInputs()
        {
            Size = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[Size][];
            int[] array = new int[Size*Size];
            int counter = 0;
            for (int a_i = 0; a_i < Size; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
                foreach (int item in a[a_i])
                {
                    array[counter] = item;
                    counter++;
                }
                
            }
            return array;
        }

        public static int Compute(int[] inputarray)
        {

            int totalDiff = Calculate(inputarray,Size);
            return totalDiff;
        }

        private static int Calculate(int[] inputarray,int size)
        {
            int rightdownDiagnolvalue = inputarray[0];
            int positionRight = 0;
            int leftDownDiagnolValue = inputarray[size-1];
            int positionleft = size - 1;

            while(true)
            {
                positionRight = positionRight + size + 1;
                rightdownDiagnolvalue = rightdownDiagnolvalue + inputarray[positionRight];
                positionleft = positionleft + size - 1;
                leftDownDiagnolValue = leftDownDiagnolValue + inputarray[positionleft];

                if (positionRight + 1 == inputarray.Length)
                    break;
            }

           

            return Math.Abs( rightdownDiagnolvalue - leftDownDiagnolValue);
        }

    }

}
