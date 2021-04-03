namespace AbstractFactory.Products
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "Product B1";
        }

        public string AnotherUsefulFunction(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            
            return $"Product B1 - ({result})";
        }
    }
}