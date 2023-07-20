using System.ComponentModel.DataAnnotations;
using Bogus;

namespace generate_data_bogus.Models;

public class Produto
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Nome { get; set; } = string.Empty;

    [Required]
    public decimal Preco { get; set; }

    public static Faker<Produto> Fake()
    {
        return new Faker<Produto>("pt_BR")
            .RuleFor(p => p.Id, f => Guid.NewGuid())
            .RuleFor(p => p.Nome, f => f.Commerce.ProductName())
            .RuleFor(p => p.Preco, f => f.Random.Decimal(10, 100));
    }    
}
