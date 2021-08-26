using DesignPatterns.Behavioral.Visitor.Abstractions;
using DesignPatterns.Behavioral.Visitor.Parts;

namespace DesignPatterns.Behavioral.Visitor
{
    public class Computer : IComputerPart
    {
        private readonly IComputerPart[] _parts;

        public Computer()
        {
            _parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            foreach (IComputerPart part in _parts)
            {
                part.Accept(computerPartVisitor);
            }
            
            // Double dispatch
            computerPartVisitor.Visit(this);
        }
    }
}
