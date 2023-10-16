﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Elev
{
    private string Nume { get; set; } = string.Empty;
    private string Prenume { get; set; } = string.Empty;
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
        desc.AppendLine(($"{Nume} {Prenume} {Marca}") );
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
