public class Masina
{
    //Auto-implemented Property
    private string Marca { get; set; }
    private string NumarDeInmatriculare { get; set; }
    private int CapacitateCilindrica { get; set; }
    
    public readonly List<string> ListaPasageri = new List<string>();

    public Masina(string marca, string numarDeInmatriculare, int capacitateaCilindrica)
    {
        Marca = marca;
        NumarDeInmatriculare = numarDeInmatriculare;
        CapacitateCilindrica = capacitateaCilindrica;
    }
    
    public static void AdaugaPasager(string pasager, List<string> ListaPasageri)
    {
        ListaPasageri.Add(pasager);
    }
    
    public static void StergePasager(string pasager, List<string> ListaPasageri)
    {
        if (ExistaPasager(pasager, ListaPasageri) != "")
        {
            ListaPasageri.Remove(pasager) ;
        }
    }
    
    public static string ExistaPasager(string pasager, List<string> ListaPasageri)
    {
        if (ListaPasageri.IndexOf(pasager) == -1)
        {
            return "";
        }
        return pasager;
    }

    public static string GetPasageri(List<string> ListaPasageri)
    {
        string Result = "";
        foreach (var item in ListaPasageri) 
        { 
            Result += item+ "\n"; 
        }
        return Result;
    }

    public string GetDescription => Marca + " , " + NumarDeInmatriculare + " , " + CapacitateCilindrica + "cmc";
}
