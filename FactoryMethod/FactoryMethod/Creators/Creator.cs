namespace FactoryMethod
{
    /// <summary>
    /// Класс Создатель
    /// Данный класс содержит фабричный метод, который позволяет создать класс продукта
    /// Дочерние классы обычно содержат уже конретную реализацию фабричного метода
    /// </summary>
    public abstract class Creator
    {
        /// <summary>
        /// Фабричный метод, позволяет создать экземляр продукта
        /// (обычно в коде используется название Create)
        /// </summary>
        /// <returns>Продукт</returns>
        public abstract IProduct FactoryMethod();

        /// <summary>
        /// Операция, с какой-то бизнес логикой которая иллюстирирует работу над созданным продуктом
        /// </summary>
        /// <returns>Результат работы операции</returns>
        public string SomeOperation()
        {
            // Вызываем фабричный метод и получаем экземпляр продукта
            var product = FactoryMethod();

            var result = "Creator worked with: " + product.Operation();

            return result;
        }
    }
}