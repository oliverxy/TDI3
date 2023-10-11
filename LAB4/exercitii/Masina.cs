using System.Runtime.CompilerServices;
using System.Text;

public class Masina
{
    //Auto-implemented Property
    private string marca { get; set; }
    private string numarDeInmatriculare { get; set; }
    private int capacitateCilindrica { get; set; }

    private List<string> ListaPasageri = new List<string>();

    public Masina(string marca, string numarDeInmatriculare, int capacitateaCilindrica)
    {
        this.marca = marca;
        this.numarDeInmatriculare = numarDeInmatriculare;
        this.capacitateCilindrica = capacitateaCilindrica;
    }

    public void AdaugaPasager(string pasager)
    {
        if (!ExistaPasager(pasager))
        {
            ListaPasageri.Add(pasager);
        }
    }

    public void StergePasager(string pasager)
    {
        if (ExistaPasager(pasager))
        {
            ListaPasageri.Remove(pasager);
        }
    }

    public bool ExistaPasager(string pasager)
    {
        return ListaPasageri.Contains(pasager);
    }

    public string GetPasageri()
    {
        StringBuilder Result = new StringBuilder();
        foreach (var pasager in ListaPasageri)
        {
            Result.AppendLine(pasager);
        }
        return Result.ToString();
    }

    public string GetDescription => $"{marca} / {numarDeInmatriculare} / {capacitateCilindrica}";
}
