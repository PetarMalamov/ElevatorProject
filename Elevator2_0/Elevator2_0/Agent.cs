using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elevator2_0
{
    class Agent
    {
        private bool leavework = false;
        public string currentFloor { get; set; }
        private List<string> AccessLevel = new List<string>();
        static Random rnd = new Random();
        public int id { get; set; }
        private Elevator elevator;
        private Building build;
        public Agent(int id, Elevator el, Building build)
        {
            this.id = id;
            this.build = build;
            elevator = el;
            build.AddToBuilding(this);
            AddAccessLevel();
            currentFloor = AccessLevel[0];
        }

        public void Dosomething()
        {
            int act;
            while (!leavework)
            {
                act = rnd.Next(1, 4);
                switch (act)
                {
                    case 1:
                        Work();
                        Thread.Sleep(2000);
                        break;
                    case 2:
                        UseElevator();
                        Thread.Sleep(1000);
                        break;
                    case 3:
                        leavework = true;
                        Leave();
                        Thread.Sleep(1000);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Leave()
        {
            Console.WriteLine($"Agent {id} wants to leave work");
            if (!currentFloor.Equals(AccessLevel[0]))//check if the agent is on ground floor
            {
                UseElevator();
            }
            build.RemoveFormList(this);
            Console.WriteLine($"Agent {id} left");
        }

        private void UseElevator()
        {
            Console.WriteLine($"Agent {id} pressed the elevator button");
            elevator.CallElevator(currentFloor);
            lock (elevator)
            {
                WaitForElevator();
                string floor;
                if (leavework)// if the agent wants to leave make the next floor to be ground floor
                {
                    floor = AccessLevel[0];
                }
                else
                {
                    floor = ChooseFloor();
                }
                WaitForDestination(floor);
            }
        }

        private void WaitForDestination(string floor)
        {
            string nextFloor = floor;
            if (nextFloor == currentFloor)//if the elevator is on the same floor ,don't use it
            {
                Console.WriteLine($"Agent {id} is already on the requested floor");
            }
            else
            {
                elevator.GoTo(nextFloor);//add request
                while (elevator.ElevatorFloor != nextFloor)
                {
                    Console.WriteLine($"Agent {id} is in the elevator");
                    Thread.Sleep(500);
                }
            }
            currentFloor = nextFloor;
            Console.WriteLine($"Agent {id} is on floor:{currentFloor}");
        }

        private void WaitForElevator()
        {
            while (!currentFloor.Equals(elevator.ElevatorFloor))//wait till the elevator is on the same floor
            {
                Console.WriteLine($"Agent {id} is waiting for the elevator");
                Thread.Sleep(500);
            }
        }

        private string ChooseFloor()
        {
            bool correctFloor = false;
            int floor;
            string nextFloor = "";
            while (!correctFloor)
            {
                floor = rnd.Next(elevator.Floors.Count);
                if (AccessLevel.Contains(elevator.Floors[floor]))//check if the agents has access to this floor
                {
                    correctFloor = true;
                    nextFloor = elevator.Floors[floor];

                }
            }
            return nextFloor;
        }

        private void Work()
        {
            Console.WriteLine($"Agent {id} is working on floar: {currentFloor}");
        }


        private void AddAccessLevel()
        {
            lock (AccessLevel)
            {
                int num = rnd.Next(1, 4);
                switch (num)//add the access levels to the agent
                {
                    case 1:
                        AccessLevel.Add("G");
                        break;
                    case 2:
                        AccessLevel.Add("G");
                        AccessLevel.Add("S");
                        break;
                    case 3:
                        AccessLevel.Add("G");
                        AccessLevel.Add("S");
                        AccessLevel.Add("T1");
                        AccessLevel.Add("T2");
                        break;
                    default:
                        AccessLevel.Add("G");
                        break;
                }
            }
        }
    }
}
