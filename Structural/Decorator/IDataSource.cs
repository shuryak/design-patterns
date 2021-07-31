namespace DesignPatterns.Structural.Decorator
{
    public interface IDataSource
    {
        public void WriteData(string data);
        public string ReadData();
    }
}
