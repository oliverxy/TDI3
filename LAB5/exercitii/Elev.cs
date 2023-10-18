using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Elev
{
    public string Nume { get; private set; } = string.Empty;
    public string Prenume { get; private set; } = string.Empty;
    private string Marca { get; set; } = string.Empty;
    private string Cnp { get; } = string.Empty;
    private List<int> Note = new List<int>();

    public Elev(string nume, string prenume, string cnp)
    {
        this.Nume = nume;
        this.Prenume = prenume;
        this.Cnp = cnp;
    }
    public Elev(string nume, string prenume, string cnp, string marca) : this(nume, prenume, cnp)
    {
        this.Marca = marca;
    }
    public void AdaugaNota(int nota)
    {
        Note.Add(nota);
    }
    public double Media
    {
        get
        {
            if (Note.Count == 0) return 0.00;
            double suma = 0;
            foreach (var nota in Note)
            {
                suma += nota;
            }
            return Math.Round(suma / Note.Count, 2);
        }
    }
    
    public string Description
    {
        get
        {
            StringBuilder desc = new StringBuilder();
            desc.AppendLine(($"{Nume} {Prenume} {Marca}"));
            desc.Append(("Note : "));
            foreach (var note in Note)
            {
                desc.Append(note.ToString());
                desc.Append(" ");
            }
            //desc.AppendLine();
            return desc.ToString();
        }
    }
}
