using Command.Interfaces;
using Command.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class HotTubOffCommand : ICommand
    {
        HotTub hotTub;
        public HotTubOffCommand(HotTub hotTub)
        {
            this.hotTub = hotTub;
        }
        public void Execute()
        {
            hotTub.JetsOff();
        }
    }
}
