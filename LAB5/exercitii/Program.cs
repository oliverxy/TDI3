// See https://aka.ms/new-console-template for more information
using exercitii;

Console.WriteLine("Hello, World!");
var elev1 = new Elev("Nume1", "Prenume1", "1234567890123","1");
var elev2 = new Elev("Nume2", "Prenume2", "2234567890123","2");
var elev3 = new Elev("Nume3", "Prenume3", "3234567890123","3");
elev1.AdaugaNota( 7); elev1.AdaugaNota(10); elev1.AdaugaNota(10);
elev2.AdaugaNota( 9); elev2.AdaugaNota(10); elev2.AdaugaNota(10);
elev3.AdaugaNota( 7); elev3.AdaugaNota( 6); elev3.AdaugaNota( 8);

var catalog = new CatalogScolar();
catalog.AdaugaElev(elev1);
catalog.AdaugaElev(elev2);
catalog.AdaugaElev(elev3);
Console.WriteLine(elev1.GetDescription());
Console.WriteLine($"Medie elev : {elev1.GetMedia()}\n");
Console.WriteLine(elev2.GetDescription());
Console.WriteLine($"Medie elev : {elev2.GetMedia()}\n");
Console.WriteLine(elev3.GetDescription());
Console.WriteLine($"Medie elev : {elev3.GetMedia()}\n");
var premiant = catalog.GetPremiantul();
Console.WriteLine($"Premiantul clasei este : {premiant.GetDescription()}");
Console.WriteLine($"Avand media : {premiant.GetMedia()}\n");
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
var vagon1 = new VagonPersoaneClasaI(52);
var vagon2 = new VagonPersoane(52);
var vagon3 = new VagonPersoane(52);
var tren = new Tren("TREN 1");
tren.AdaugaLocomotiva(locomotiva1);
tren.AdaugaVagon(vagon1);
tren.AdaugaVagon(vagon2);
tren.AdaugaVagon(vagon3);
tren.Porneste();
tren.Opreste();
