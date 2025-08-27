using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Vendor
{
    internal class HotTub
    {
        public void JetsOn()
        {
            Console.WriteLine("Set Jets ON");
        }

        public void JetsOff()
        {
            Console.WriteLine("Set Jets OFF");
        }

        public void SetTemperature(int nr)
        {
            Console.WriteLine("Set Temperature to " + nr);
        }
    }
}
