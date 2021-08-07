using System;

namespace DesignPatterns.Behavioral.Command
{
    public class Game
    {
        public void Fire()
        {
            Console.WriteLine("Fire!");
        }

        public void OpenDoor()
        {
            Console.WriteLine("Opening the door!");
        }

        public void Jump()
        {
            Console.WriteLine("Jump!");
        }

        public void ThrowGrenade()
        {
            Console.WriteLine("Throwing a grenade!");
        }

        public void CheatAction()
        {
            Console.WriteLine(">>> Cheat code enabled! <<<");
        }
    }
}
