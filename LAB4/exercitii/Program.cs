using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Dulap dulap = new(80, 40, 30);
        Console.WriteLine($"Volumul unui dulap {dulap.GetDescription} = {dulap.GetVolum}");

        Masina masina = new("Dacia", "TM01MAI", 1300);
        Console.WriteLine("Model masina " + masina.GetDescription);
        masina.AdaugaPasager("Popescu Ion");
        masina.AdaugaPasager("Popescu Maria");
        masina.AdaugaPasager("Popescu Gheorhe");
        Console.WriteLine(masina.GetPasageri());

        string TestPasager = "Popescu Maria";
        masina.StergePasager(TestPasager);


        Console.WriteLine("Pasagerul " + TestPasager + (masina.ExistaPasager(TestPasager) != "" ? "" : " NU mai") + " exista");



    }
}