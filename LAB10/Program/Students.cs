using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Infrastructure;
using System.Xml.Linq;

using var dbStudent = new StudentsDbContext();


//Seed();

var lista = dbStudent.Students.OrderBy(s => s.Nume).ToList();
lista.ForEach(s => Console.WriteLine(s));
Console.WriteLine();

var dd = dbStudent.Specializari.Where(s => s.Nume == "Constructii").Select(s => s.Id).FirstOrDefault();
lista = dbStudent.Students.Where(s => s.SpecializareId == dd && s.Varsta > 20).ToList();
lista.ForEach(s => Console.WriteLine(s));
Console.WriteLine();

var lista1 = dbStudent.Students
    .OrderBy(s => s.SpecializareId + s.Nume)
    .GroupBy(s => s.SpecializareId)
    .ToList();
  
lista1.ForEach(s => {
    Console.WriteLine(s.Key);
    s.ToList().ForEach(s => Console.WriteLine(s));
    });



Console.ReadLine();

//TODO: NU AR TREBUI SA STEARGA SI ANGAJATUL
dbStudent.Specializari.Where(x => x.Id == 2).ExecuteDelete();




static void Seed()
{
    using var dbStudents = new StudentsDbContext();
    var dd = dbStudents.Specializari.Where(s => s.Nume == "Litere").Select(s => s.Id).FirstOrDefault();
    dbStudents.Add(new Specializare
    {
        Nume = "Litere"
    });
    dbStudents.Add(new Specializare
    {
        Nume = "Constructii"
    });
    dbStudents.Add(new Specializare
    {
        Nume = "Informatica"
    });
    dbStudents.SaveChanges();
    dbStudents.Specializari.Where(s => s.Nume == "Litere");

    dbStudents.Add(new Student { 
        Nume = "Popescu",
        Prenume = "Ana",
        Varsta = 20,
        SpecializareId = dbStudents.Specializari.Where(s => s.Nume == "Litere").Select(s => s.Id).FirstOrDefault()
    });
    dbStudents.Students.Add(new Student
    {
        Nume = "Popescu",
        Prenume = "Ion",
        Varsta = 23,
        SpecializareId = dbStudents.Specializari.Where(s => s.Nume == "Constructii").Select(s => s.Id).FirstOrDefault()
    });
    dbStudents.Students.Add(new Student
    {
        Nume = "Ionescu",
        Prenume = "Mirela",
        Varsta = 21,
        SpecializareId = dbStudents.Specializari.Where(s => s.Nume == "Informatica").Select(s => s.Id).FirstOrDefault()
    });
    dbStudents.Students.Add(new Student
    {
        Nume = "Ionescu",
        Prenume = "Florina",
        Varsta = 22,
        SpecializareId = dbStudents.Specializari.Where(s => s.Nume == "Constructii").Select(s => s.Id).FirstOrDefault()
    });
    dbStudents.Students.Add(new Student
    {
        Nume = "Tomescu",
        Prenume = "Nelu",
        Varsta = 25,
        SpecializareId = dbStudents.Specializari.Where(s => s.Nume == "Constructii").Select(s => s.Id).FirstOrDefault()
    });


    dbStudents.SaveChanges();
}



class StudentsDbContext: DbContext
{ 
    public DbSet<Student> Students { get; set; }
    public DbSet<Specializare> Specializari { get; set; }

    public StudentsDbContext():base()
    {
        Database.EnsureCreated();
    } 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
        .UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oliver.rotunjanu\source\repos\TDI3\LAB10\Program\StudentsDb.mdf;Integrated Security=True");
        //.LogTo(Console.WriteLine);
    }
}

class Student
{
    public int Id { get; private set; } 
    public string Nume { get; set; }
    public string Prenume { get; set; }
    public int Varsta { get; set; } = 0;
    public int SpecializareId  { get; set; }
    public Specializare Specializare { get; set; }
    public override string ToString() => $"{Nume} {Prenume} : ID {Id}, sp.{SpecializareId}";
}

class Specializare
{
    public int Id { get; private set; }
    public string Nume { get; set; }
    //public Student Student { get; set; }
    public override string ToString() => $"{Nume} {Id}";

}

