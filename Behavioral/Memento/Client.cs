namespace DesignPatterns.Behavioral.Memento
{
    /*
     * Pattern Memento allows making snapshots of an object’s state and restoring it in future
     */
    public class Client
    {
        public void Main()
        {
            Originator originator = new Originator();
            Caretaker caretaker = new Caretaker(originator);
            
            originator.SetState("State 1");
            
            caretaker.Backup();
            
            originator.SetState("State 2");
            
            caretaker.Undo();
        }
    }
}
