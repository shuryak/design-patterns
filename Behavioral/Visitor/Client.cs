namespace DesignPatterns.Behavioral.Visitor
{
    /*
     * Pattern Visitor allows adding new behaviors to existing class hierarchy without changing an existing code
     */
    public class Client
    {
        public void Main()
        {
            Computer computer = new Computer();
            
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}
