using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}