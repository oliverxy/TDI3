using System.Runtime.CompilerServices;

public class Masina
{
    //Auto-implemented Property
    private string Marca { get; set; }
    private string NumarDeInmatriculare { get; set; }
    private int CapacitateCilindrica { get; set; }

    private List<string> ListaPasageri = new List<string>();

    public Masina(string marca, string numarDeInmatriculare, int capacitateaCilindrica)
    {
        Marca = marca;
        NumarDeInmatriculare = numarDeInmatriculare;
        CapacitateCilindrica = capacitateaCilindrica;
    }

    public void AdaugaPasager(string pasager)
    {
        ListaPasageri.Add(pasager);
        
    }

    public void StergePasager(string pasager)
    {
        if (ExistaPasager(pasager) != "")
        {
            ListaPasageri.Remove(pasager);
        }
    }

    public string ExistaPasager(string pasager)
    {
        if (ListaPasageri.IndexOf(pasager) == -1)
        {
            return "";
        }
        return pasager;
    }

    public string GetPasageri()
    {
        string Result = "";
        foreach (var item in ListaPasageri)
        {
            Result += item + "\n";
        }
        return Result;
    }

    public string GetDescription => $"{Marca} / {NumarDeInmatriculare} / {CapacitateCilindrica}";
}
