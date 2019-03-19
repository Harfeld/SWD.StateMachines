using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Flashlight_states
{
    public abstract class FlashlightState
    {
        public abstract void handlePower(Flashlight context);
    }
}
