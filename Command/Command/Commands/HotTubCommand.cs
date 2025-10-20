using Command.Interfaces;
using Command.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class HotTubCommand:ICommand
    {
        HotTub hotTub;
        public HotTubCommand(HotTub hotTub)
        {
            this.hotTub = hotTub;
        }

        public void Execute()
        {
            hotTub.SetTemperature(40);
            hotTub.JetsOn();
        }

        public void Undo()
        {
            hotTub.JetsOff();
        }
    }
}
