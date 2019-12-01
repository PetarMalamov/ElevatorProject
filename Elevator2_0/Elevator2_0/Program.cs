using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elevator2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Thread> threads = new List<Thread>();
            Building build = new Building();
            Elevator elevator = new Elevator(build);

            for (int i = 0; i < 3; i++)
            {
                Agent a = new Agent(i, elevator, build);
                Thread t = new Thread(() => a.Dosomething());
                threads.Add(t);
            }


            Thread thr = new Thread(() => elevator.DoWork());
            threads.Add(thr);
            foreach (var t in threads)
            {
                t.Start();
            }

            foreach (var t in threads)
            {
                t.Join();
            }
            Console.WriteLine();
            Console.WriteLine("Building is empty");
        }
    }
}
