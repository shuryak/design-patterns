using DesignPatterns.Behavioral.Visitor.Parts;

namespace DesignPatterns.Behavioral.Visitor.Abstractions
{
    public interface IComputerPartVisitor
    {
        void Visit(Computer computer);
        void Visit(Mouse mouse);
        void Visit(Keyboard keyboard);
        void Visit(Monitor monitor);
    }
}
