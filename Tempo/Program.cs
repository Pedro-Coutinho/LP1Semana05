using System;
using System.Threading;
using System.Diagnostics;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();

            Thread.Sleep(500);

            crono2.Start();

            Thread.Sleep(300);

            crono1.Stop();
            crono2.Stop();

            TimeSpan crono1T = crono1.Elapsed;
            TimeSpan crono2T = crono2.Elapsed;

            string crono1elapsedTime = String.Format("{0}.{1:00}",
            crono1T.Seconds, crono1T.Milliseconds / 10);

            string crono2elapsedTime = String.Format("{0}.{1:00}",
            crono2T.Seconds, crono2T.Milliseconds / 10);

            Console.WriteLine(crono1elapsedTime);
            Console.WriteLine(crono2elapsedTime);
        }
    }
}
