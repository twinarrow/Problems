using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Thread
{
    class Program
    {
        static void Main(string[] args)
        {

            start();
        }

        private static void start()
        {
            CallWithAsync();
        }

        private async static void CallWithAsync()
        {
            //some other tasks
            string result = await GreetingAsync("Bulbul");
            //We can add  multiple "await" in same "async" method
            //string result1 = await GreetingAsync("Ahmed");
            //string result2 = await GreetingAsync("Every Body");
            Console.WriteLine(result);
        }
        static Task<string> GreetingAsync(string name)
        {
            return Task.Run<string>(() =>
            {
                return Greeting(name);
            });
        }
        static string Greeting(string name)
        {
           
            Thread.Sleep(3000);

            return string.Format("Hello, {0}", name);

        }
    }
}
