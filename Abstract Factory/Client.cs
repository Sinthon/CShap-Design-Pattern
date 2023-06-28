namespace Creational_Design_Pattern.Abstract_Factory;

public class Client
{
    private IShapeFactory _shapeFactory;

    public Client(IShapeFactory shapeFactory)
    {
        _shapeFactory = shapeFactory;
    }

    public void DrawShape()
    {
        IShape shape = _shapeFactory.CreateShape();
        shape.Draw();
    }
}
