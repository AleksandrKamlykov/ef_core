namespace bs_first.Entities;

public class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public override string ToString()
    {
        return $"Id: {Id}; Name: {Name}; Description: {Description}";
    }
}