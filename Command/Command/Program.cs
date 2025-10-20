using Command.Commands;
using Command.Vendor;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotTub hotTub = new HotTub();
            SimpleRemote remote = new SimpleRemote();
            remote.slot = new HotTubCommand(hotTub);


            remote.ButtonPress1();
        }
    }
}
