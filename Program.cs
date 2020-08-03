using System;
using System.Threading;

namespace LoadingBar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task task = new Task(() => Console.Write(i1));
            //task.Start();

            Console.Write("\n\n\n\n\n\n\n\n\n\n\n");
            for (int i1 = 0; i1 < 45; i1++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(i1);
                Thread.Sleep(150);
                if (i1 == 44)
                {
                    return;
                }
            }
        }
    }
}