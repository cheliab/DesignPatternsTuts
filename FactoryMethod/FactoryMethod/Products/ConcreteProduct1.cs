namespace FactoryMethod
{
    /// <summary>
    /// Конкретный продукт 1
    /// Предоставляет реализацию интерфейса продукта
    /// </summary>
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}