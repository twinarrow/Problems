using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    private long aVeryBigSum(int n, long[] ar)
    {
        // Complete this function
        int count = 0;
        
        long sumvalue =0;
        while (count < ar.Length)
        {
            sumvalue = this.sum((long)ar[count], sumvalue);
            count++;
        }
        //string sumvalue = this.sum((long)ar[0], (long)ar[1]);
        return sumvalue;

    }
    public long sum(long first, long Second)
    {
        if (first == 0 || Second == 0)
            return first + Second;

        string result = string.Empty;
        string broughtDownString = string.Empty;
        int carryNumber = 0;

        if (first < Second)
            swap(ref first, ref Second);

        string firststr = first.ToString();
        string secondstr = Second.ToString();

        for (int i = 0; i < firststr.Length; i++)
        {
            int temp = int.Parse( firststr.Substring(firststr.Length-1-i, 1))  % (int)Math.Pow(10, (i + 1));
            long denominator = (long)Math.Pow(10, (i));/// 10;

            int Number1 = temp;/// denominator;

            // (first % 10^(i+1)) / (10^(i+1) / 10 ) 
            if (i == secondstr.Length)
            {
                broughtDownString = ((int)(first / denominator )).ToString();
                break;
            }
            int temp2 = int.Parse(secondstr.Substring(secondstr.Length - 1 - i, 1)) % (int)Math.Pow(10, (i + 1));

            int Number2 = temp2;/// denominator;
            int SumNumber = Number1 + Number2;
            int localCarryNumber = 0;
            SumNumber = carryNumber + SumNumber;
            if (SumNumber > 9)
                localCarryNumber = SumNumber/10;
            SumNumber = SumNumber % 10;

           
            result = (SumNumber).ToString() + result;

            carryNumber = localCarryNumber;
  


        }
        return long.Parse(broughtDownString + result);
    }

    private void swap(ref long p, ref long q)
    {
        long temp;
        temp = p;
        p = q;
        q = temp;
    }

    static void Main(String[] args)
    {
        Solution sol = new Solution();
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
        long result = sol.aVeryBigSum(n, ar);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
