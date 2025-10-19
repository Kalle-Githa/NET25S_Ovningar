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

// Console.WriteLine("Skriv in vädrden för en student");
// Console.WriteLine("Namn");

// string namn = Console.ReadLine();

// Console.WriteLine("Efternamn");
// string efternamn = Console.ReadLine();
// Console.WriteLine("Email");
// string email = Console.ReadLine();
// Console.WriteLine("Telefonnummer");
// string telefonnummer = Console.ReadLine();

// var nyStudent = new Student(namn, efternamn, email, telefonnummer);

// Console.WriteLine(nyStudent.KontroleraVarder());

// // Console.WriteLine(nyStudent.KontroleraVarder()); // Detta är lärares sätt att göra det på
// Console.WriteLine(
//     $"{nyStudent.Förnamn}, {nyStudent.Efternamn}, {nyStudent.Email}, {nyStudent.Telefonnummer}"
// );

// //========== Övning 6 ================
