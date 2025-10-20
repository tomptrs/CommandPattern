using Command.Interfaces;
using Command.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class OutDoorLightCommand : ICommand
    {
        OutDoorLight light;
        public OutDoorLightCommand(OutDoorLight light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }
    }
}
