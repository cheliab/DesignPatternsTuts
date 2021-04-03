namespace FactoryMethod
{
    /// <summary>
    /// Конкретный продукт 2
    /// Так же реазилует интерфейс продукта
    /// </summary>
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}