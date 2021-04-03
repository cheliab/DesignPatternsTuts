namespace FactoryMethod
{
    /// <summary>
    /// Конкретный создатель
    /// Данный класс переопределяет фабричный метод, чтобы создать тот тип продукта который ему нужен
    /// </summary>
    public class ConcreteCreator1 : Creator
    {
        /// <summary>
        /// Фабричный метод с созданием конкретного продукта
        /// Важно что данный метод также продолжает использовать интерфейс в качестве результата работы методы
        /// Это позволяет не привязываться к конкретной реализации класса
        /// </summary>
        /// <returns>Конкретный продукт</returns>
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}