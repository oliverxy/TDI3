// See https://aka.ms/new-console-template for more information
using exercitii;

Console.WriteLine("Hello, World!");
var elev1 = new Elev("Nume1", "Prenume1", "1234567890123","1");
var elev2 = new Elev("Nume2", "Prenume2", "2234567890123","2");
var elev3 = new Elev("Nume3", "Prenume3", "3234567890123","3");
elev1.AdaugaNota( 7); elev1.AdaugaNota(10); elev1.AdaugaNota(10);
elev2.AdaugaNota( 9); elev2.AdaugaNota(10); elev2.AdaugaNota(10);
elev3.AdaugaNota( 7); elev3.AdaugaNota( 6); elev3.AdaugaNota( 8);

var catalog = new CatalogScolar("Catalog1");
catalog.AdaugaElev(elev1);
catalog.AdaugaElev(elev2);
catalog.AdaugaElev(elev3);
Console.WriteLine(elev1.Description);
Console.WriteLine($"Medie elev : {elev1.Media}\n");
Console.WriteLine(elev2.Description);
Console.WriteLine($"Medie elev : {elev2.Media}\n");
Console.WriteLine(elev3.Description);
Console.WriteLine($"Medie elev : {elev3.Media}\n");
var premiant = catalog.Premiantul;
if (premiant != null)
{
    Console.WriteLine($"Premiantul clasei este : {premiant.Description}");
    Console.WriteLine($"Avand media : {premiant.Media}\n");
}
Console.WriteLine();
Console.WriteLine();

var locomotiva1 = new Locomotiva("LOCOMOTIVA1", 3000);
locomotiva1.Start();
if (locomotiva1.isStarted == true)
{
    Console.WriteLine($"Locomotiva {locomotiva1.Name} a pornit !");
}
locomotiva1.Stop();
if (locomotiva1.isStarted == false)
{
    Console.WriteLine($"Locomotiva {locomotiva1.Name} s-a oprit !");
}
var tren = new Tren("TREN 1",locomotiva1);
tren.AdaugaLocomotiva(locomotiva1);
tren.AdaugaVagon(new VagonPersoaneClasaI("1",100,1990,52));
tren.AdaugaVagon(new VagonPersoane("2", 100, 1990, 52));
tren.AdaugaVagon(new VagonPersoane("3", 100, 1990, 52));
tren.AdaugaVagon(new VagonCuseta("4", 100, 1990, 12));
tren.PleacaDinGara();
tren.SosesteInGara();
