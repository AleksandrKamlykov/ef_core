using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bs_first.Entities;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public string LastName { get; set; } = null!;
    [NotMapped]
    public  string PersonalInfo { get; set; } = null!;

    public DateOnly BirthDay { get; set; }
    
    override public string ToString()
    {
        return $"Id: {Id}, Name: {Name}, BirthDay: {BirthDay}";
    }
}
