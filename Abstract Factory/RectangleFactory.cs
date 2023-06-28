namespace Creational_Design_Pattern.Abstract_Factory;

public class RectangleFactory : IShapeFactory
{
    public IShape CreateShape()
    {
        return new Rectangle();
    }
}
