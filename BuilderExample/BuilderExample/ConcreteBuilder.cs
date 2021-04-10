using System.Threading;

namespace BuilderExample
{
    /// <summary>
    /// Класс конкретного строителя
    /// (Должен реализовывать общий интерфейс строителей)
    /// </summary>
    public class ConcreteBuilder : IBuilder
    {
        /// <summary>
        /// Продукт который планируется создать
        /// </summary>
        private Product _product = new Product();

        /// <summary>
        /// При создании строителя создается новый продукт
        /// </summary>
        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }
        
        public void BuildPartA()
        {
            _product.Add("Part A 1");
        }

        public void BuildPartB()
        {
            _product.Add("Part B 1");
        }

        public void BuildPartC()
        {
            _product.Add("Part C 1");
        }

        public Product GetProduct()
        {
            Product result = _product;
            
            Reset();

            return result;
        }
    }
}