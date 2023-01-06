// See https://aka.ms/new-console-template for more information
using BedónAdrián_EjemploFactoryMethod;

//Console.WriteLine("Hello, World!");

Pizzería pizzería;
Pizza pizza;

pizzería = new PizzeriaQuito();

pizza = pizzería.CrearPizza("napo");
pizza.Render();
pizza = pizzería.CrearPizza("carnes");
pizza.Render();

pizzería = new PizzeriaGuayaquil();

pizza = pizzería.CrearPizza("napo");
pizza.Render();
pizza = pizzería.CrearPizza("carnes");
pizza.Render();

Console.ReadKey();