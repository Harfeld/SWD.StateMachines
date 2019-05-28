using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5.Flashlight_states
{
    public class FlashlightState
    {
        public virtual void handlePower(Flashlight context){ }
        public virtual void handleMode(Flashlight context) { }
        public virtual void OnEnter(Flashlight context) { }
    }

    public class Off : FlashlightState
    {
        public override void OnEnter(Flashlight context)
        {
            context.LightOff();
        }

        public override void handlePower(Flashlight context)
        {
            context.SetState(new On());
        }
    }
    public class On : FlashlightState
    {
        public override void OnEnter(Flashlight context)
        {
            context.LightOn();
            context.SetState(new Solid());
        }

        public override void handlePower(Flashlight context)
        {
            context.SetState(new Off());
        }
    }
    public class Solid : On
    {
        public override void OnEnter(Flashlight context)
        {
            context.ModeSolid();
        }

        public override void handleMode(Flashlight context)
        {
            context.SetState(new Flashing());
        }
    }
    public class Flashing : On
    {
        public override void OnEnter(Flashlight context)
        {
            context.ModeFlashing();
        }

        public override void handleMode(Flashlight context)
        {
            context.SetState(new Solid());
        }
    }
}
