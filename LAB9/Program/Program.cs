// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var angajati = new List<Angajat>();


angajati.Add(new Angajat("Popescu El", 3800, Departments.Development));
angajati.Add(new Angajat("Popescu Ea", 3500, Departments.HumanResources));
angajati.Add(new Angajat("Popescu AlMic", 3300, Departments.Testing));
angajati.Add(new Angajat("Ionescu El", 3800, Departments.Development));
angajati.Add(new Angajat("Ionescu Ea", 3400, Departments.Logistics));
angajati.Add(new Angajat("Ionescu Nepot", 3400, Departments.Testing));
angajati.Add(new Angajat("Lacatusu", 3400, Departments.Maintenance));

angajati.ForEach(a => Console.WriteLine(a));
Console.WriteLine();
var noOfWellPayedEmployees = angajati.Count(a => a.Salary>=3300 );
    Console.WriteLine($"noOfWellPayedEmployees: {noOfWellPayedEmployees}");
    Console.WriteLine();    
var employeesFromMaintenance = angajati.Where(a => a.Department == Departments.Maintenance).ToList();
    Console.WriteLine("employeesFromMaintenance:");
    employeesFromMaintenance.ForEach(a => Console.WriteLine(a));
    Console.WriteLine();
double lnSal = 0.0;
lnSal = angajati.Max(a => a.Salary);
var MaxSalay = angajati.Where(a => a.Salary == lnSal).ToList();
    Console.WriteLine($"MaxSalay:");
    MaxSalay.ForEach(a => Console.WriteLine(a));
    Console.WriteLine();
lnSal = angajati.Where(a => a.Department == Departments.Development).Max(a => a.Salary);
var maxSalaryForDevelopment = angajati.Where(a => a.Salary == lnSal).ToList();
    Console.WriteLine($"maxSalaryForDevelopment:");
    maxSalaryForDevelopment.ForEach(a => Console.WriteLine(a));
    Console.WriteLine();
var totalCost = angajati.Sum(a => a.Salary);
    Console.WriteLine($"totalCost: {totalCost}");
    Console.WriteLine();
var costLogistic = angajati.Where(a => a.Department == Departments.Logistics).Sum(a => a.Salary);
    Console.WriteLine($"totalCost: {costLogistic}");
    Console.WriteLine();

var id = angajati.Find(a => a.Name == "Popescu Ea");
//id.Salary *= 1.25;
var IncreaseSalary = angajati.Find(a => a.Id == id.Id).Salary*1.25;

var IncreaseSalaryForTesting = angajati.Where(a => a.Department == Departments.Testing);

var OrderedHumanResources = 
    angajati.Where(a => a.Department == Departments.HumanResources)
            .OrderBy(a => a.Name.ToLowerInvariant())
            .ThenByDescending(a => a.Salary)
            .ToList();
    Console.WriteLine($"OrderedHumanResources:");
    OrderedHumanResources.ForEach(a => Console.WriteLine(a));
    Console.WriteLine();

lnSal = angajati.Min(a => a.Salary);

var PoorestDevelopmentEmployee = 
    angajati.Where(a => a.Department == Departments.Development)
            .FirstOrDefault(a => a.Salary == lnSal);
    Console.WriteLine($"PoorestDevelopmentEmployee:{PoorestDevelopmentEmployee}");
    Console.WriteLine();

var LogisticsWithRangeExists = angajati.Any(a => a.Salary >= 5000 && a.Salary <= 6000);
    Console.WriteLine($"LogisticsWithRangeExists: {LogisticsWithRangeExists}");
    Console.WriteLine();


var depts = new List<Departments> { Departments.Development, Departments.HumanResources, Departments.Testing };


var maxSalaryByDepartment =
    angajati.FindAll(a => depts.Contains(a.Department))
            .OrderByDescending(a => a.Salary)
            .GroupBy(b => b.Department)
            .Select(g =>
            {
                var maxSalary = g.Max(e => e.Salary);
                return new
                {
                Dep = g.Key,
                Employees = g.Where(e => e.Salary == maxSalary).ToList(),
                MaxSalary = maxSalary
                };
            });
//.ToDictionary(c=>c.Key,c=>c.ToList())
Console.WriteLine("maxSalaryByDepartment:");
maxSalaryByDepartment
    .ToList()
    .ForEach(a => {
        Console.WriteLine($"Grupul angajatiilor din {a.Dep} avand salariul maxim {a.MaxSalary}");
        a.Employees.ForEach(equals => Console.WriteLine(equals.Name)) ;
        }
    );




class Angajat
{
    public string Name { get; set; } = string.Empty;
    public Guid Id { get; private set; } = Guid.NewGuid();
    public double Salary { get; set; } = 0.0;
    public Departments Department { get; set; }

    public Angajat(string name, double salary, Departments department)
    {
        this.Name = name;
        this.Salary = salary;
        this.Department = department;
    }
    public override string ToString() => $"{Name} ( {Id} ) : {Department} -> {Salary}";

}

enum Departments
{
    Development,
    Testing,
    HumanResources,
    Maintenance,
    Logistics
}