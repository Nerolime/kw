using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irrigationSystem
{
    class Pump
    {
        bool isActive = false;
        int quantitySpinkers;
        Sprinkler[] sprinklers;

        public void SprinklerCheck()
        {
            for (int i = 0; i < quantitySpinkers; i++)
            {
                sprinklers[i].HumidityCheck();
            }
        }
    }
}
