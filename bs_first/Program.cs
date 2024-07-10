using bs_first;
using bs_first.Entities;
using bs_first.Context;

//AddSudent();
ReadStudent();
// Console.WriteLine("-------");
//  EditStudent();
//  ReadStudent();

static void ReadStudent()
{
    using (MyDbContext db = new MyDbContext())
    {

        var students = db.Students.ToList();
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}

static void ReadGroups()
{
    using (MyDbContext db = new MyDbContext())
    {
        var groups = db.Groups.ToList();
        foreach (var group in groups)
        {
            Console.WriteLine(group);
        }
    }
}

static void EditStudent()
{
    using (MyDbContext db = new MyDbContext())
    {
        try
        {
            Student? student = db.Students.FirstOrDefault(e => e.Name == "Svitlana");
            Console.WriteLine(student);


            if (student != null)
            {
                student.BirthDay = new DateOnly(1993, 10, 13);
                db.SaveChanges();
            }


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            //throw;
        }
    }
}

static void AddSudent()
{
    using (MyDbContext db = new MyDbContext())
    {
        Student student2 = new Student
        {
         Name = "Oleksandr",
         LastName = "Kamlykov",
         BirthDay = new DateOnly(1994,11,18)
        };


        db.Students.Add(student2);
        db.SaveChanges();
    }
}
