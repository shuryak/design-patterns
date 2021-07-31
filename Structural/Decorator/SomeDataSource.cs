namespace DesignPatterns.Structural.Decorator
{
    public class SomeDataSource : IDataSource
    {
        private string Data { get; set; } = "";

        public void WriteData(string data)
        {
            Data = data;
        }

        public string ReadData()
        {
            return Data;
        }
    }
}
