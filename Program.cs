// See https://aka.ms/new-console-template for more information
//using Creational_Design_Pattern.Abstract_Factory;
using Creational_Design_Pattern.Prototype;
//using Creational_Design_Pattern.Singleton;
//using Creational_Design_Pattern.Builder;
//using Creational_Design_Pattern.Factory;

Console.WriteLine("C#-Design-Pattern");


//// Factory pattern Usage
//ProductFactory factory = new ProductFactory();
//Client client = new Client(factory);
//client.DoSomethingWithProduct("A");
//client.DoSomethingWithProduct("B");


////Builder pattern Usage
//IBuilder builder = new ConcreteBuilder();
//Director director = new Director(builder);

//director.Construct();
//Product product = builder.GetProduct();
//Console.WriteLine(product.Attribute1);
//Console.WriteLine(product.Attribute2);


////Abstract Factory pattern Usage
//IShapeFactory circleFactory = new CircleFactory();
//Client client1 = new Client(circleFactory);
//client1.DrawShape(); // Output: Drawing a circle

//IShapeFactory rectangleFactory = new RectangleFactory();
//Client client2 = new Client(rectangleFactory);
//client2.DrawShape(); // Output: Drawing a rectangle



////Singleton Usage
//Singleton obj1 = Singleton.GetInstance();
//obj1.MyProperty = "This is message form object one";

//Console.WriteLine(obj1.MyProperty);

//Singleton obj2 = Singleton.GetInstance();
//obj2.MyProperty = "This is message form object two";

//Console.WriteLine(obj1.MyProperty);

Shape originalRectangle = new Rectangle();
Shape clonedRectangle = (Shape)originalRectangle.Clone();

originalRectangle.Draw();
clonedRectangle.Draw();

Console.ReadKey();