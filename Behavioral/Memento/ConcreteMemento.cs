namespace DesignPatterns.Behavioral.Memento
{
    public class ConcreteMemento : IMemento
    {
        private readonly string _state;

        public ConcreteMemento(string stateToSave)
        {
            _state = stateToSave;
        }

        public string GetState()
        {
            return _state;
        }
    }
}
