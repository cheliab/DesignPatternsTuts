namespace AbstractFactory.Products
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "Product B2";
        }

        public string AnotherUsefulFunction(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            
            return $"Product B2 - ({result})";
        }
    }
}