// See https://aka.ms/new-console-template for more information
using Creational_Design_Pattern.Builder;
using Creational_Design_Pattern.Factory;

Console.WriteLine("C#-Design-Pattern");


//// Factory pattern Usage
//ProductFactory factory = new ProductFactory();
//Client client = new Client(factory);
//client.DoSomethingWithProduct("A");
//client.DoSomethingWithProduct("B");


//Builder pattern Usage
IBuilder builder = new ConcreteBuilder();
Director director = new Director(builder);

director.Construct();
Product product = builder.GetProduct();
Console.WriteLine(product.Attribute1);
Console.WriteLine(product.Attribute2);

Console.ReadKey();