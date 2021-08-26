namespace DesignPatterns.Behavioral.Visitor.Abstractions
{
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
