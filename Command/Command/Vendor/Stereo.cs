using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Vendor
{
    internal class Stereo
    {
        public void On()
        {
            Console.WriteLine("Set Stereo ON");
        }

        public void Off()
        {
            Console.WriteLine("Set Stereo OFF");
        }

        public void setCd()
        {
        }

        public void SetDVD()
        { }

        public void SetRadio()
        {
        }

        public void SetVolume(int nr)
        {
            Console.WriteLine("Set Volume to " + nr);
        }
    }
}
