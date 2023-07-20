using System.ComponentModel.DataAnnotations;
using Bogus;

namespace generate_data_bogus.Models;

public class Cliente
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Nome { get; set; } = string.Empty;

    [Required]
    public string Email { get; set; } = string.Empty;

    public static Faker<Cliente> Fake()
    {
        return new Faker<Cliente>("pt_BR")
            .RuleFor(u => u.Id, f => Guid.NewGuid())
            .RuleFor(u => u.Nome, f => f.Name.FullName())
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.Nome));
    }    
}
