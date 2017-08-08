using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManupulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] input = Console.ReadLine().Split(' ');
            GetInputs();
            reverse();
            output();

        }

        static string str, revstring;
        static int length;
        private static void reverse()
        {
            length = str.Length - 1;
            while (length >=0)
            {
                revstring = revstring + str[length];
                length--;
            }
        }

        public static void GetInputs()
        {
            str = Console.ReadLine();
        }

        private static  void output()
        {
            Console.WriteLine("Thre reveresed is : {0}", revstring);
            Console.ReadLine();
        }
    }
}
