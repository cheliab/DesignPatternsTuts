namespace BuilderExample
{
    /// <summary>
    /// Директор
    /// (позволяет воздавать разные варианты продукта)
    /// </summary>
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        /// <summary>
        /// Создание продукс с минимальными настройками
        /// </summary>
        public void BuildMinimalViableProduct()
        {
            _builder.BuildPartA();
        }

        /// <summary>
        /// Максимально укомлектованный продукт
        /// </summary>
        public void BuildFullFeaturedProduct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }
}