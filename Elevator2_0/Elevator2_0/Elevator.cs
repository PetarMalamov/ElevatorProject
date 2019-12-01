using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elevator2_0
{
    class Elevator
    {
        public List<string> Floors = new List<string> { "G", "S", "T1", "T2" };
        static List<string> requests = new List<string>();
        Building build;
        private object obj = new object();
        public string ElevatorFloor { get; set; }
        private int timeBetweenFloors { get; set; }
        public bool empty { get; set; }
        public Elevator(Building build)
        {
            this.build = build;
            ElevatorFloor = Floors[0];
        }

        public void DoWork()
        {
            while (build.agentList.Count > 0)
            {
                if (requests.Count > 0)
                {
                    string nextRequest = GetNextRequest();
                    timeBetweenFloors = CalculateTime(ElevatorFloor, nextRequest);
                    Thread.Sleep(timeBetweenFloors);
                    ElevatorFloor = nextRequest;
                    Console.WriteLine($"Elevator is at floor:{ElevatorFloor}");
                    Thread.Sleep(2000);
                }
            }
        }

        private int CalculateTime(string x, string y)
        {
            int elFloor = Floors.FindIndex(a => a == x) + 1;//Find the index of the floor and increment it by one
            int agFloor = Floors.FindIndex(a => a == y) + 1;
            int time = Math.Abs(elFloor - agFloor) * 1000;//get's the result as a positive number
            return time;//return time between floors
        }

        private string GetNextRequest()
        {
            string oldestRequest = requests[0];
            requests.RemoveAt(0);
            while (oldestRequest == ElevatorFloor && requests.Count > 0)
            {

                oldestRequest = requests[0];
                requests.RemoveAt(0);

            }
            return oldestRequest;
        }

        public void CallElevator(string floor)
        {
            lock (requests)
            {
                requests.Add(floor);
            }
        }

        public void GoTo(string floor)
        {
            lock (obj)
            {
                requests.Insert(0, floor);
            }
        }
    }
}
