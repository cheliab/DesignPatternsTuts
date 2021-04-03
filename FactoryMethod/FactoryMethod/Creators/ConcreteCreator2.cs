namespace FactoryMethod
{
    /// <summary>
    /// Второй конкретный создатель
    /// Работает уже с другим типом продукта 
    /// </summary>
    public class ConcreteCreator2 : Creator
    {
        /// <summary>
        /// Конкретный фабричный метод с другим типом продукта
        /// </summary>
        /// <returns>Конкретный продукт</returns>
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}