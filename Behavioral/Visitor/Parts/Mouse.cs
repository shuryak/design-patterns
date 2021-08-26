using DesignPatterns.Behavioral.Visitor.Abstractions;

namespace DesignPatterns.Behavioral.Visitor.Parts
{
    public class Mouse : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            // Double dispatch
            computerPartVisitor.Visit(this);
        }
    }
}
