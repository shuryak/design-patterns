using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Memento
{
    public class Caretaker
    {
        private readonly Stack<IMemento> _mementos = new Stack<IMemento>();

        private readonly Originator _originator = null;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("Caretaker: Saving Originator's state...");
            _mementos.Push(_originator.SaveAsMemento());
        }

        public void Undo()
        {
            if (_mementos.Count == 0) return;

            IMemento memento = _mementos.Pop();
            
            Console.WriteLine("Caretaker: Restoring state...");
            
            _originator.RestoreFromMemento(memento);
        }
    }
}
