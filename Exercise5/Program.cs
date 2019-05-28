using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Flashlight context = new Flashlight();
            var choice = 'x';


            while (char.ToUpper(choice) != 'Q')
            {
                Console.Write("Enter event : ");
                choice = Console.ReadKey().KeyChar;
                Console.Write("\n");

                switch (char.ToUpper(choice))
                {
                    case 'P':
                        context.Power();
                        break;

                    case 'M':
                        context.Mode();
                        break;
                }
            }
        }
    }
}
