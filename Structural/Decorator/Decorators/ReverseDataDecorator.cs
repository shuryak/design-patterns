using System;

namespace DesignPatterns.Structural.Decorator.Decorators
{
    public class ReverseDataDecorator : DataSourceDecorator
    {
        public ReverseDataDecorator(IDataSource wrappee) : base(wrappee)
        {
        }
        
        public override void WriteData(string data)
        {
            char[] charArray = data.ToCharArray();
            Array.Reverse(charArray);
            
            Wrappee.WriteData(new string(charArray));
        }

        public override string ReadData()
        {
            char[] charArray = Wrappee.ReadData().ToCharArray();
            Array.Reverse(charArray);
            
            return new string(charArray);
        }
    }
}
