using Command.Interfaces;
using Command.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class StereoOnCommand : ICommand
    {
        Stereo stereo;
        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.SetVolume(17);
            stereo.On();
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
