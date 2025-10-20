using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;


namespace Command
{
    internal class SimpleRemote
    {
        private ICommand[] slotsOn;
        private ICommand[] slotsOff;
        public SimpleRemote()
        {
            slotsOn = new ICommand[3];
            slotsOff = new ICommand[3];
        }
        public void AddSlot(int nr, ICommand on, ICommand off)
        {
            slotsOff[nr]    = off;
            slotsOn[nr]     = on;
        }

        public void ButtonPressOn(int nr) {
            slotsOn[nr].Execute();
        }
        public void ButtonPressOff(int nr)
        {
            slotsOff[nr].Execute();
        }
    }
}
