// //========== Övning 1-5 ================

// var kurs = new Kurs { };
// Console.WriteLine("");

// Console.WriteLine("Ange Kursens namn");
// kurs.KursNamn = Console.ReadLine();

// Console.WriteLine("Ange Start datum ");
// DateTime.TryParse(Console.ReadLine(), out var startDatum);
// kurs.StartDatum = startDatum;
// Console.WriteLine("Ange Slut datum");
// DateTime.TryParse(Console.ReadLine(), out var slutDatum);
// kurs.SlutDatum = slutDatum;
// Console.WriteLine("Ange Poäng");
// int p = int.Parse(Console.ReadLine());
// kurs.Poäng = p;
// Console.WriteLine("");

// // var antalDagar = kurs.BeraknaAntalKursDagar();

// Console.WriteLine(
//     $"Kurs info: Kursnamn = {kurs.KursNamn}, startdatum = {kurs.StartDatum} slutdatum = {kurs.SlutDatum} Poäng = {kurs.Poäng} Antal dagar {kurs.BeraknaAntalKursDagar()} Poäng/kursdag{kurs.PoangPerKursdag()}"
// );

using System.Runtime.InteropServices;

Console.WriteLine("Skriv in vädrden för en student");
Console.WriteLine("Namn");

string namn = Console.ReadLine();

Console.WriteLine("Efternamn");
string efternamn = Console.ReadLine();
Console.WriteLine("Email");
string email = Console.ReadLine();
Console.WriteLine("Telefonnummer");
string telefonnummer = Console.ReadLine();

var nyStudent = new Student(namn, efternamn, email, telefonnummer);

Console.WriteLine(nyStudent.KontroleraVarder());
Console.WriteLine(nyStudent.SammanFattning());

// Console.WriteLine(nyStudent.KontroleraVarder()); // Detta är lärares sätt att göra det på
// Console.WriteLine(
//     $"{nyStudent.Förnamn}, {nyStudent.Efternamn}, {nyStudent.Email}, {nyStudent.Telefonnummer}"
// );

// //========== Övning 6 ================

Console.WriteLine(nyStudent.HamtaBetyg());
Console.WriteLine("Vill du rensa alla värden? j/n");

string svar = Console.ReadLine()!.ToLower();
if (svar == "j")
{
    nyStudent.RensaUppgifter();
    Console.WriteLine(
        $"{nyStudent.Förnamn}, {nyStudent.Efternamn}, {nyStudent.Email}, {nyStudent.Telefonnummer}"
    );
}
var lärare = new Larare { Namn = "anna", Email = "gmail" };

Console.WriteLine(lärare.SammanFattning());

foreach (var k in lärare.AnsvarigForKurser())
{
    Console.WriteLine(k);
}

Console.WriteLine("Sätt alla propertys för  lektion nr 1 ");
var lektion1 = new Lektion();
Klassrum klassrum = new Klassrum();
Console.Write("Datum: ");
DateTime.TryParse(Console.ReadLine(), out var datum);
lektion1.Datum = datum;

Console.Write("Kurs:");
lektion1.Kurs = Console.ReadLine();
Console.Write("Klassrum: ");
lektion1.Klassrum = Console.ReadLine();
lektion1.Boka();
lektion1.TaBort();
klassrum.Lektioner.Add(lektion1);

//____________________________________________________________

Console.WriteLine("Sätt alla propertys för lektion nr 2 ");
var lektion2 = new Lektion();
Console.Write("Datum: ");
DateTime.TryParse(Console.ReadLine(), out var datum2);
lektion2.Datum = datum2;

Console.Write("Kurs:");
lektion2.Kurs = Console.ReadLine();
Console.Write("Klassrum: ");
lektion2.Klassrum = Console.ReadLine();
lektion2.Boka();
lektion2.TaBort();

bool ledigt = klassrum.KontrolleraLedigt(lektion2.Datum);

Console.WriteLine($"Metoden returnerade: {ledigt}");
if (ledigt)
    Console.WriteLine("Ledigt");
else
    Console.WriteLine("Upptaget");

klassrum.Lektioner.Add(lektion2);

foreach (var l in klassrum.HamtaLektioner())
{
    Console.WriteLine($"{l.Kurs}, {l.Datum}, {l.Klassrum}");
}

Console.WriteLine($"Jämför {lektion2.Datum:d} med {lektion1.Datum:d}");


// if (klassrum.KontrolleraLedigt(lektion2.Datum))
// {
//     Console.WriteLine("Ledigt");
// }
// else
// {
//     Console.WriteLine("Upptaget");
// }

/// Console.WriteLine("Detta är kurserna: ");
// Console.WriteLine(lärare.AnsvarigForKurser());
