namespace FactoryMethod.Abstractions
{
    public abstract class Creator
    {
        protected abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();

            string result = "Creator: " + product.Operation();

            return result;
        }
    }
}
