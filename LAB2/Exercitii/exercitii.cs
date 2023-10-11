using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

internal class Lab2
{
    private static void Main()
    {
        Console.Clear();
        Console.WriteLine("Alegeti exercitiul de executat");
        Console.WriteLine("");
        Console.WriteLine("1. Media aritmetica n numere");
        Console.WriteLine("2. Verifica daca un numar este palindrom");
        Console.WriteLine("3. Verifica daca un numar este prim");
        Console.WriteLine("4. Piramida numere pare 2 -> n");
        Console.WriteLine("5. Operatii pe un vector");
        Console.WriteLine("");
        uint nNr;
        nNr = uint.Parse(Console.ReadLine());
        switch (nNr)
        {
            case 1: Ex1(); break;
            case 2: Ex2(); break;
            case 3: Ex3(); break;
            case 4: Ex4(); break;
            case 5: Ex5(); break;
            default: break;
        }


    }
    private static void Ex1()
    {
        // Console.WriteLine("1.  Media aritmetica n numere");
        Console.Write("Cate numere se vor citi: ");
        int i, nSuma, numar, nNrPare = 0;
        int nNr = int.Parse(Console.ReadLine());
        for (i = 1, nSuma = 0; i <= nNr; i++)
        {
            Console.Write("Introducere numarul " + i + ": ");
            numar = int.Parse(Console.ReadLine());
            if (numar % 2 == 0)
            {
                nSuma += numar;
                nNrPare++;
            }
        }
        if (nNrPare > 0)
        {
            double media = nSuma / nNrPare;
            Console.WriteLine("Media aritmetica a celor {0} numere pare este : {1}", nNrPare, media);
        }
        else Console.WriteLine("Numere pare = 0");

    }

    private static void Ex2()
    {
        //Console.WriteLine("2. Verifica daca un numar este palindrom");
        Console.Write("Introducere numarul:");
        int nNr = int.Parse(Console.ReadLine());
        Console.WriteLine("Numarul {0}{1} este palindrom", nNr, IsPalindron(nNr) ? "" : " NU");
    }


    private static void Ex3()
    {
        //Console.WriteLine("2. Verifica daca un numar este prim");
        Console.Write("Introducere numarul:");
        int nNr = int.Parse(Console.ReadLine());
        Console.WriteLine("Numarul {0}{1} este palindrom", nNr, IsPrime(nNr) ? "" : " NU");
    }


    private static void Ex4()
    {
        //Console.WriteLine("4. Piramida numere pare 2 -> n");
        Console.Write("Introducere numarul:");
        int nNr = int.Parse(Console.ReadLine());
        for (int i = 1; i <= nNr; i++)
        {
            if (i % 2 == 0) Console.WriteLine(GetOddString(i));
        }
    }


    private static void Ex5()
    {
        Console.Write("Introducere numarul de elemente ale vectorului:");
        int nNr = int.Parse(Console.ReadLine());
        int[] vect;
        vect = new int[nNr];
        for (int i = 0; i < nNr; i++)
            vect[i] = new Random().Next(0, 100);
        Console.Write("Vectorul generat : ");
        for (int i = 0; i < nNr; i++)
            Console.Write(vect[i] + " ");
        Console.WriteLine();
        Console.WriteLine("Maximul vectorului generat : {0}", GetMaximVector(vect));
        Console.WriteLine("Minimul vectorului generat : {0}", GetMinimVector(vect));
        // Console.WriteLine("Numere divizibile cu 3 : {0}", GetMaximVector(vect);
    }


    private static bool IsPalindron(int n)
    {
        int inv, aux;
        for (aux = n, inv = 0; aux > 0; aux /= 10)
        {
            inv = inv * 10 + aux % 10;
        }
        return inv == n;
    }

    private static bool IsPrime(int n)
    {
        //init = contor de plecare
        //verifica daca numarul este divizibil cu numerele cuprinse intre 2 si jumatatea lui
        for (int init = 2; init < n / 2; init++)
        {
            //testeaza daca are divizor
            if (n % init == 0)
            {
                return false;
            };
        }
        return true;
    }

    private static bool IsDivided(int numar, int divizor)
    {
        return numar % divizor == 0;
    }

    private static string GetOddString(int n)
    {
        string result = "";
        for (int i = 1; i <= n / 2; i++)
        {
            result += n;
        }
        return result;
    }

    private static int GetMaximVector(int[] vector)
    {
        int result = vector[0];
        for (int i = 0; i < vector.Length - 1; i++)
        {
            if (vector[i] > result)
            {
                result = vector[i];
            }
        }
        return result;
    }

    private static int GetMinimVector(int[] vector)
    {
        int result = vector[0];
        for (int i = 0; i < vector.Length - 1; i++)
        {
            if (vector[i] >= result)
            {
                continue;
            }
            result = vector[i];

        }
        return result;
    }
}


