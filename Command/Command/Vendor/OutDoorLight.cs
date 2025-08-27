using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Vendor
{
    internal class OutDoorLight
    {
        public void On()
        {
            Console.WriteLine("Outdoor light ON");
        }

        public void Off()
        {
            Console.WriteLine("Outdoor light OFF");
        }
    }
}
