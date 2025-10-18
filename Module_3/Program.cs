// Console.Write("Skriv något: ");

// var m = new Medelande { Text = Console.ReadLine() };
// Console.WriteLine(m.VisaMedelande());
var kurs = new Kurs { };

Console.WriteLine("Ange Kursens namn");
kurs.KursNamn = Console.ReadLine();

Console.WriteLine("Ange Start datum ");
DateTime.TryParse(Console.ReadLine(), out var startDatum);
kurs.StartDatum = startDatum;
Console.WriteLine("Ange Slut datum");
DateTime.TryParse(Console.ReadLine(), out var slutDatum);
kurs.SlutDatum = slutDatum;
Console.WriteLine("Ange Poäng");
int p = int.Parse(Console.ReadLine());
kurs.Poäng = p;
Console.WriteLine("");

// var antalDagar = kurs.BeraknaAntalKursDagar();

Console.WriteLine(
    $"Kurs info: Kursnamn = {kurs.KursNamn}, startdatum = {kurs.StartDatum} slutdatum = {kurs.SlutDatum} Poäng = {kurs.Poäng} Antal dagar {kurs.BeraknaAntalKursDagar()} Poäng/kursdag{kurs.PoangPerKursdag()}"
);
