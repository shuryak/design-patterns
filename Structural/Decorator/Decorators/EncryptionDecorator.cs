using System.Collections.Generic;

namespace DesignPatterns.Structural.Decorator.Decorators
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource wrappee) : base(wrappee)
        {
        }
        
        public override void WriteData(string data)
        {
            Wrappee.WriteData(CaesarEncrypt(data, 3));
        }

        public override string ReadData()
        {
            string data = Wrappee.ReadData();
            
            return CaesarEncrypt(data, -3);
        }
        
        private static string CaesarEncrypt(string text, int shift)
        {
            List<char> alphabet = new List<char>();
            for (char c = 'A'; c <= 'Z'; c++)
                alphabet.Add(c);
            for (char c = 'a'; c <= 'z'; c++)
                alphabet.Add(c);
            
            string result = "";
            foreach (char c in text)
            {
                int index = alphabet.IndexOf(c);
                if (index >= 0)
                {
                    int encryptedLetterIndex = (alphabet.Count + index + shift) % alphabet.Count;
                    result += alphabet[encryptedLetterIndex];
                }
                else
                {
                    result += c.ToString();
                }
            }

            return result;
        }
    }
}
