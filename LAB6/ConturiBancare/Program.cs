
namespace LAB6;
internal class programs
{
    private static void Main()
    {
        var cont = new Conturi.ContEconomii("caritas", 0.01);
        cont.RetragereNumerar(1000);
        cont.RetragereNumerar(-1000);
        Console.WriteLine(cont);

    }
}
