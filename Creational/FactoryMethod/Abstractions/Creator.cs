namespace DesignPatterns.Creational.FactoryMethod.Abstractions
{
    public abstract class Creator
    {
        protected abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            IProduct product = FactoryMethod();

            string result = "Creator: " + product.Operation();

            return result;
        }
    }
}
