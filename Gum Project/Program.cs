using System;
using System.Collections.Generic;
using System.Threading;

namespace CodeBlogFithness
{
    class test
    {
        public test()
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Mtavari Nakadi";
            Console.WriteLine(thread.Name);
            Console.WriteLine(thread.IsAlive);
            Console.WriteLine(thread.Priority);
            thread.Priority = ThreadPriority.Highest;
            Console.WriteLine(thread.Priority);

            Console.WriteLine(thread.ThreadState);
            Console.WriteLine(thread.IsBackground);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread ";
            CountUp();
            CountDown();
            Console.WriteLine($"{mainThread.Name} Complete");
        }
        static void CountUp()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Timer #1 {i} second");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Timer #1 Complete");
        }

        static void CountDown()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Timer #2 {i} second");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Timer #2 Complete");
        }
    }
}
