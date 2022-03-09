namespace AW1.DesignPatterns.AbstractFactory
{
    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }

    public interface IProductA
    {
        string Name { get; set; }
    }

    public interface IProductB
    {
        string ID { get; set; }
    }
}
