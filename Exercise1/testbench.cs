using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class testbench
    {
        static void Main(string[] args)
        {
            Flashlight test = new Flashlight();
            test.pressPower();
            test.pressPower();
        }
    }
}
