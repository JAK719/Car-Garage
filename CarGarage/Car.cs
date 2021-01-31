using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }
        public bool AutoBrakeActive { get; set; }


        public string SetMake(string make)
        {
            Make = make;
            return make;
        }

        public string SetModel(string model)
        {
            Model = model;
            return model;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public bool IsSpeeding()
        {
            if(Speed >= 71)
            {
                return true;
            }
            else
            {
                return false;
            }
      

        }


        public int Accelerate()
        {
            if(Speed <= 90 && Make != "Ferrari")
            {
                return Speed += 10;
            }
            else if(Speed <= 80 && Make == "Ferrari")
            {
                return Speed += 20;
            }

            else
            {
                return Speed;
            }

        }

        public int Brake()
        {
            if(Speed >= 7 && AutoBrakeActive == false)
            {
                return Speed -= 7;
            }
            else if(AutoBrakeActive == true)
            {
               return Speed /= 2;

            }
            else
            {
                return Speed -= Speed;
            }
                   
            
        }

      
    }
}
