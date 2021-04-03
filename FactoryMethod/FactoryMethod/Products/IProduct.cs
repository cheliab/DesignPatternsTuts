namespace FactoryMethod
{
    /// <summary>
    /// Интерфейс Продукта
    /// Объявляет операции, которые должны выполнять все конкретные продукты
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Какая-то операция продукта
        /// </summary>
        /// <returns>Результат операции</returns>
        string Operation();
    }
}