using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irrigationSystem
{
    class Sprinkler
    {
        bool isActive = false;
        int humidity;
     
        DateTime _wateringTime;
       public void HumidityCheck()
        {
            //считывает показания датчика и записывает в humidity
            if(humidity < 30)
            {
                isActive = true;
            }
            if (humidity >= 80)
            {
                isActive = false;
            }
        }
        void SetWateringTime( DateTime wateringTime)
        {
            _wateringTime = wateringTime;
        }
    }
}
