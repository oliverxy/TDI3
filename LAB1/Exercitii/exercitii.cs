using System;

internal class Lab1
{
    private static void Main()
    {
        Console.Clear();
        Console.WriteLine("Alegeti exercitiul de executat");
        Console.WriteLine("");
        Console.WriteLine("1. Calcul volum dreptunghi paralelipipedic");
        Console.WriteLine("2. Calcul media aritmetica 3 numere");
        Console.WriteLine("3. Afisare ultima cifra a unui numar");
        Console.WriteLine("4. Afisare semnul unui numar");
        Console.WriteLine("5. Afisare 2 numare in ordine crescatoare");
        Console.WriteLine("6. Afisare 3 numare in ordine crescatoare");
        Console.WriteLine("7. Afisare daca un numar este par sau impar");
        Console.WriteLine("8. Interschimba 2 numere intregi");
        Console.WriteLine("9. Afisare text numar");
        uint nNr;
        nNr = uint.Parse(Console.ReadLine());
        switch (nNr)
        {
            case 1: Ex1(); break;
            case 2: Ex2(); break;
            case 3: Ex3(); break;
            case 4: Ex4(); break;
            case 5: Ex5(); break;
            case 6: Ex6(); break;
            case 7: Ex7(); break;
            case 8: Ex8(); break;
            case 9: Ex9(); break;
            default: break;
        }


    }
    private static void Ex1()
    {
        // Console.WriteLine("1. Calcul volum dreptunghi paralelipipedic");
        uint nLungime, nLatime, nInaltime;
        Console.WriteLine("Lungime baza:");
        nLungime = uint.Parse(Console.ReadLine());
        Console.WriteLine("Latime baza:");
        nLatime = uint.Parse(Console.ReadLine());
        Console.WriteLine("Inaltime:");
        nInaltime = uint.Parse(Console.ReadLine());
        Console.WriteLine("Volum dreptunghi paralelipipedic:" + nLungime * nLatime * nInaltime);
    }

    private static void Ex2()
    {
        //Console.WriteLine("2. Calcul media aritmetica 3 numere");
        uint nNr1, nNr2, nNr3;
        Console.WriteLine("Introducere numar 1:");
        nNr1 = uint.Parse(Console.ReadLine());
        Console.WriteLine("Introducere numar 2:");
        nNr2 = uint.Parse(Console.ReadLine());
        Console.WriteLine("Introducere numar 3:");
        nNr3 = uint.Parse(Console.ReadLine());
        Console.WriteLine("Media aritmtica a celor 3 numere este:" + (nNr1 + nNr2 + nNr3) / 3);
    }

    private static void Ex3()
    {
        //Console.WriteLine("3. Afisare ultima cifra a unui numar");
        int nNr;
        Console.WriteLine("Introducere numarul:");
        nNr = int.Parse(Console.ReadLine());
        Console.WriteLine("Ultima cifra a numarului "+nNr+" este " + nNr % 10);
    }

    private static void Ex4()
    {
        //Console.WriteLine("4. Afisare semnul unui numar");
        int nNr;
        Console.WriteLine("Introducere numarul:");
        nNr = int.Parse(Console.ReadLine());
        if (nNr == 0)
        { 
            Console.WriteLine(nNr);
        }
        else if (nNr <= 0)
        { 
            Console.WriteLine("-"); 
        }
        else 
        { 
            Console.WriteLine("+"); 
        }
    }

    private static void Ex5()
    {
        //Console.WriteLine("5. Afisare 2 numare in ordine crescatoare");
        int nNr1, nNr2;
        Console.WriteLine("Introducere primul numar:");
        nNr1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introducere al doilea numar:");
        nNr2 = int.Parse(Console.ReadLine());
        if (nNr1 < nNr2)
        {
            Console.WriteLine(nNr1 +" " + nNr2);
        }
        else
        {
            Console.WriteLine(nNr2 + " " + nNr1);
        }
    }

    private static void Ex6()
    {
        //Console.WriteLine("6. Afisare 3 numare in ordine crescatoare");
        int nNr1, nNr2, nNr3, nNr0;
        Console.WriteLine("Introducere primul numar:");
        nNr1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introducere al doilea numar:");
        nNr2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introducere al treilea numar:");
        nNr3 = int.Parse(Console.ReadLine());
        nNr0 = Math.Max(nNr1,Math.Max(nNr2,nNr3));
        if (nNr1 == nNr0)
        {
            if (nNr2 < nNr3)
            {
                (nNr2, nNr3) = (nNr3, nNr2);
            }
        }
        else if (nNr2 == nNr0)
        {
            (nNr1, nNr2) = (nNr2, nNr1);
            if (nNr3 > nNr2)            {
                (nNr2, nNr3) = (nNr3, nNr2);
            }
        }
        else
        {
            (nNr1, nNr3) = (nNr3, nNr1);
            if (nNr3 > nNr2)
            {
                (nNr2, nNr3) = (nNr3, nNr2);
            }
        }
        Console.WriteLine(nNr1 + " " + nNr2 + " " + nNr3);
    }


    private static void Ex7()
    {
        //Console.WriteLine("7. Afisare daca un numar este par sau impar");
        int nNr;
        Console.WriteLine("Introducere numarul:");
        nNr = int.Parse(Console.ReadLine());
        if (nNr % 2 == 0)
        {
            Console.WriteLine("Numarul este par.");
        }
        else
        {
            Console.WriteLine("Numarul este impar.");
        }
    }


    private static void Ex8()
    {
        //Console.WriteLine("8. Interschimba 2 numere intregi");
        int nNr1, nNr2;
        Console.WriteLine("Introducere primul numar:");
        nNr1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introducere al doilea numar:");
        nNr2 = int.Parse(Console.ReadLine());
        (nNr1, nNr2) = (nNr2, nNr1);
        Console.WriteLine(nNr1 + " " + nNr2);
    }


    private static void Ex9()
    {
        //Console.WriteLine("9. Afisare text numar");
        int nNr;
        Console.WriteLine("Introducere numarul:");
        nNr = int.Parse(Console.ReadLine());
        string txt;
        switch (nNr) 
        {
            case 1: txt = "unu"; break;
            case 2: txt = "doi"; break;
            case 3: txt = "trei"; break;
            case 5: txt = "cinci"; break;
            case 8: txt = "opt"; break;
            default: txt = "neidentificat"; break;
        }  
        Console.WriteLine(nNr + " => " + txt);
    }
}

