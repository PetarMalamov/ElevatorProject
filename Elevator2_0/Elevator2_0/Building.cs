using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator2_0
{
    class Building
    {
        public List<Agent> agentList = new List<Agent>();
        public Building()
        {

        }

        public void AddToBuilding(Agent x)
        {
            agentList.Add(x);
        }

        public void RemoveFormList(Agent x)
        {
            agentList.Remove(x);
        }
    }
}
