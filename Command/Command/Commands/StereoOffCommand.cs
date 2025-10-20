using Command.Interfaces;
using Command.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class StereoOffCommand : ICommand
    {
        Stereo stereo;
        public StereoOffCommand(Stereo stereo) { this.stereo = stereo; }
        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
        }
    }
}
