using System;

namespace DesignPatterns.Behavioral.Memento
{
    public class Originator
    {
        private string _state;

        public void SetState(string state)
        {
            Console.WriteLine($"Originator: Setting state to \"{state}\"");
            _state = state;
        }

        public IMemento SaveAsMemento()
        {
            Console.WriteLine("Originator: Saving to Memento...");
            return new ConcreteMemento(_state);
        }

        public void RestoreFromMemento(IMemento memento)
        {
            _state = memento.GetState();
            Console.WriteLine($"Originator: State after restoring from Memento: \"{_state}\"");
        }
    }
}
