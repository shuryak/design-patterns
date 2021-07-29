using System;
using DesignPatterns.Structural.Bridge.BridgeEnds;
using DesignPatterns.Structural.Bridge.BridgeStarts;

namespace DesignPatterns.Structural.Bridge
{
    public class Client
    {
        /*
         * Pattern Bridge encloses some logic in interface (Abstraction hierarchy, here the bridge starts) and keeps a 
         * reference to its implementation (Implementation hierarchy, here the bridge ends)
         */
        public void Main()
        {
            Tv tv = new Tv();
            Remote remote = new Remote(tv);
            Console.WriteLine(remote.VolumeUp());

            Radio radio = new Radio();
            AdvancedRemote remote2 = new AdvancedRemote(radio);
            Console.WriteLine(remote2.Mute());
        }
    }
}
