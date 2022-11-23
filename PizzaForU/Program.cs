using PizzaForU.Data;
using PizzaForU.Models;

using PizzaForUContext context = new PizzaForUContext();

var pizzas = context.Pizzas
    .Where(p => p.Price < 12.00M)
    .OrderBy(p => p.Name);


foreach (var p in pizzas)
{
    Console.WriteLine($"ID: {p.PizzaId}");
    Console.WriteLine($"NAME: {p.Name}");
    Console.WriteLine($"PRICE: {p.Price}");
    Console.WriteLine(new string('-', 80));
}


Pizza Pepperoni = new Pizza()
{
    Name = "Pepperoni",
    Price = 9.99M
};

context.Pizzas.Add(Pepperoni);

Pizza MeatLover = new Pizza()
{
    Name = "MeatLover pizza",
    Price = 40.00M
};
context.Pizzas.Add(MeatLover);

context.SaveChanges();