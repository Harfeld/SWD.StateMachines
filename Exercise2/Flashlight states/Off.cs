﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Flashlight_states
{
    public class Off : FlashlightState
    {
        public override void handlePower(Flashlight context)
        {
            context.SetState(new On());
            context.LightOn();
        }
    }
}
