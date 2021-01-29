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

            Speed = Speed + 10;
            return Speed;
          
        }


    }
}
