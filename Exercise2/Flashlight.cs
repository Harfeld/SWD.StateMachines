using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise2.Flashlight_states;

namespace Exercise2
{
    public class Flashlight
    {
        private FlashlightState _currState;

        public Flashlight()
        {
            _currState = new Off();
        }

        public void Power()
        {
            _currState.handlePower(this);
        }

        public void LightOn()
        {
            Console.WriteLine("Turning on");
        }

        public void LightOff()
        {
            Console.WriteLine("Turning off");
        }

        public void SetState(FlashlightState state)
        {
            _currState = state;
        }
    }
}
