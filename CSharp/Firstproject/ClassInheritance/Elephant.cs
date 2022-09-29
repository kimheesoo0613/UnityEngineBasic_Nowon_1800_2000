using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassInheritance
{
    internal class Elephant : Creature, IFourLeggedWalker
    {
        public override void Breath()
        {
            
        }

        public void FourLeggedWalk()
        {
            Console.WriteLine($"코끼리가 사족보행한다");
        }
    }
}
