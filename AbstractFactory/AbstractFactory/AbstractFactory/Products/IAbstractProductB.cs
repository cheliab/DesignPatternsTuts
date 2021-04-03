namespace AbstractFactory.Products
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();

        string AnotherUsefulFunction(IAbstractProductA collaborator);
    }
}