namespace Creational_Design_Pattern.Abstract_Factory;

public class CircleFactory : IShapeFactory
{
    public IShape CreateShape()
    {
        return new Circle();
    }
}
