using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise5.Flashlight_states;

namespace Exercise5
{
    public class Flashlight
    {
        private FlashlightState _currState;

        public Flashlight()
        {
            _currState = new Off();
        }

        public void SetState(FlashlightState state)
        {
            // ==================================
            // FOR DEBUG ONLY!!!
            Console.WriteLine("State: {0} --> {1}", _currState != null ? _currState.GetType().Name : "", state.GetType().Name);
            // ==================================

            _currState = state;
            _currState.OnEnter(this);
        }

        //Flashlight Functions
        public void Power()
        {
            _currState.handlePower(this);
        }

        public void Mode()
        {
            _currState.handleMode(this);
        }

        //Actions
        public void LightOn()
        {
            Console.WriteLine("Turned on");
        }

        public void LightOff()
        {
            Console.WriteLine("Turned off");
        }

        public void ModeSolid()
        {
            Console.WriteLine("Beam is solid");
        }

        public void ModeFlashing()
        {
            Console.WriteLine("Beam is flashing");
        }
    }
}
