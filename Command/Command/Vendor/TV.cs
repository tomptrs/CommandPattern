using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Vendor
{
    internal class TV
    {
        public void On()
        {
            Console.WriteLine("TV ON");

        }

        public void Off()
        {
            Console.WriteLine("TV OFF");
        }

        public void SetInputChannel(int nr)
        {
            Console.WriteLine("Set Input Channel to " + nr);
        }

        public void SetVolume(int nr)
        {
            Console.WriteLine("Set Volume to " + nr);
        }
    }
}
