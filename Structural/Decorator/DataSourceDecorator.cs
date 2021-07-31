namespace DesignPatterns.Structural.Decorator
{
    public abstract class DataSourceDecorator : IDataSource
    {
        protected readonly IDataSource Wrappee;

        protected DataSourceDecorator(IDataSource wrappee)
        {
            Wrappee = wrappee;
        }

        public abstract void WriteData(string data);

        public abstract string ReadData();
    }
}
