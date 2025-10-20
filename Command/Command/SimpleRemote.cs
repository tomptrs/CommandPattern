using Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Command
{
    internal class SimpleRemote
    {
        public ICommand slot { get; set; }
        public void ButtonPress1()
        {
            slot.Execute();
        }
    }
}
