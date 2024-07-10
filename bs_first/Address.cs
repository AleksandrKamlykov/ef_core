using System.ComponentModel.DataAnnotations.Schema;

namespace bs_first;
[NotMapped]
public class Address
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}