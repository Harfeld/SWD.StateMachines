using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Flashlight_states
{
    public class On : FlashlightState
    {
        public override void handlePower(Flashlight context)
        {
            context.SetState(new Off());
            context.LightOff();
        }
    }
}
