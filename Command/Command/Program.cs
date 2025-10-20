using Command.Commands;
using Command.Vendor;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotTub hotTub = new HotTub();
            Stereo stereo = new Stereo();
            OutDoorLight light = new OutDoorLight();
            SimpleRemote remote = new SimpleRemote();
            remote.AddSlot(0, new HotTubCommand(hotTub), new HotTubOffCommand(hotTub));
            remote.AddSlot(1,new StereoOnCommand(stereo),new StereoOffCommand(stereo));
            remote.AddSlot(2, new OutDoorLightCommand(light), new OutDoorLightOffCommand(light));

            remote.ButtonPressOn(0);
            remote.ButtonPressOn(1);
            remote.UndoPressed();
            remote.ButtonPressOn(2);
            remote.UndoPressed();

            remote.ButtonPressOff(2);
            remote.UndoPressed();
            remote.ButtonPressOff(0);
            remote.UndoPressed();
        }
    }
}
