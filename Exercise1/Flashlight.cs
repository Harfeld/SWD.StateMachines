using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Flashlight
    {
        private bool currState;

        public Flashlight()
        {
            currState = false;
        }
        public void pressPower()
        {
            switch (currState)
            {
                case true://if on
                {
                    Console.WriteLine("Turning off");
                    currState = false;
                }
                    break;
                case false://if off
                {
                    Console.WriteLine("Turning on");
                    currState = true;
                }
                    break;
            }
        }
    }
}
