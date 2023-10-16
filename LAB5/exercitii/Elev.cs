using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Elev
{
    private string nume { get; set; } = string.Empty;
    private string prenume { get; set; } = string.Empty;
    private string nr_legitimatie { get; set; } = string.Empty;
    private string cnp { get; } = string.Empty;

    private List<int> Note = new List<int>();

    public Elev(string nume, string prenume, string cnp)
    {
        this.nume = nume;
        this.prenume = prenume;
        this.cnp = cnp;
    }
    public Elev(string nume, string prenume, string cnp, string nr_legitimatie) : this(nume, prenume, cnp)
    {
        this.nr_legitimatie = nr_legitimatie;
    }
    public void AdaugaNota(int nota)
    {
        Note.Add(nota);
    }
    public double GetMedia()
    {
        int nr = 0; 
        double suma = 0;
        foreach (var nota in Note)
        {
            suma += nota;
            nr++;
        }
        if (nr > 0) {
            return Math.Round(suma / nr, 2);
        }
        return 0;
    }
    public string GetDescription()
    {
        StringBuilder desc = new StringBuilder();
        desc.AppendLine(($"{nume} {prenume}") );
        desc.Append(("Note : ") );
        foreach (var note in Note)
        {
            desc.Append(note.ToString());
            desc.Append(" ");
        }
        //desc.AppendLine();
        return desc.ToString();
    }
}
