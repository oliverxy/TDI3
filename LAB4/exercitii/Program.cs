using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Dulap dulap = new(80, 40, 30);
        Console.WriteLine("Volumul unui dulap "+dulap.GetDescription+ " = "+dulap.Volum);

        Masina masina = new("Dacia", "TM01MAI", 1300);
        Console.WriteLine("Model masina " + masina.GetDescription);
        Masina.AdaugaPasager("Popescu Ion", masina.ListaPasageri);
        Masina.AdaugaPasager("Popescu Maria", masina.ListaPasageri);
        Masina.AdaugaPasager("Popescu Gheorhe", masina.ListaPasageri);
        Console.WriteLine(Masina.GetPasageri(masina.ListaPasageri));

        string TestPasager = "Popescu Maria";
        Masina.StergePasager(TestPasager, masina.ListaPasageri);


        Console.WriteLine("Pasagerul " + TestPasager + (Masina.ExistaPasager(TestPasager, masina.ListaPasageri) != "" ? "" : " NU mai") + " exista");



    }
}