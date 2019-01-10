using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irrigationSystem
{
    class System
    {
        Pump[] pumps;
        int quantityPumps;
        void StartWatering()
        {
            for (int i = 0; i < quantityPumps; i++)
            {
                pumps[i].SprinklerCheck();
            }
        }

    }
}
