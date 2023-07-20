using generate_data_bogus.Data;
using generate_data_bogus.Models;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Clientes Gerados");
Console.WriteLine("----------------");
Console.ResetColor();
        
var clientes = Cliente.Fake().Generate(2);

foreach (var cliente in clientes)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("    Id: ");
    Console.ResetColor();
    Console.WriteLine($"{cliente.Id}");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("  Nome: ");
    Console.ResetColor();
    Console.WriteLine($"{cliente.Nome}");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("e-mail: ");
    Console.ResetColor();
    Console.WriteLine($"{cliente.Email}\n");
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Produtos Gerados");
Console.WriteLine("----------------");
Console.ResetColor();

var produtos = Produto.Fake().Generate(3);

foreach (var produto in produtos)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("   Id: ");
    Console.ResetColor();
    Console.WriteLine($"{produto.Id}");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(" Nome: ");
    Console.ResetColor();
    Console.WriteLine($"{produto.Nome}");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("Preço: ");
    Console.ResetColor();
    Console.WriteLine($"{produto.Preco:C}\n");
}

using (var appDbContext = new AppDbContext())
{
    appDbContext.Database.EnsureCreated();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Clientes Gerados DB");
    Console.WriteLine("-------------------");
    Console.ResetColor();

    foreach (var cliente in appDbContext.Clientes.ToList())
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("    Id: ");
        Console.ResetColor();
        Console.WriteLine($"{cliente.Id}");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("  Nome: ");
        Console.ResetColor();
        Console.WriteLine($"{cliente.Nome}");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("e-mail: ");
        Console.ResetColor();
        Console.WriteLine($"{cliente.Email}\n");
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Produtos Gerados DB");
    Console.WriteLine("-------------------");
    Console.ResetColor();

    foreach (var produto in appDbContext.Produtos.ToList())
    {
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("   Id: ");
    Console.ResetColor();
    Console.WriteLine($"{produto.Id}");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(" Nome: ");
    Console.ResetColor();
    Console.WriteLine($"{produto.Nome}");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("Preço: ");
    Console.ResetColor();
    Console.WriteLine($"{produto.Preco:C}\n");
    }
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("[Esc] ");
Console.ResetColor();
Console.WriteLine("para sair");
Console.ReadKey(true);
