public class Student
{
    public string Förnamn { get; set; }
    public string Efternamn { get; set; }
    public string Email { get; set; }
    public string Telefonnummer { get; set; }

    public Student(string förnamn, string efternamn, string email, string telefonnummer)
    {
        Förnamn = förnamn;
        Efternamn = efternamn;
        Email = email;
        Telefonnummer = telefonnummer;
    }

    public string KontroleraVarder()
    {
        string felmeddelande = "";

        if (string.IsNullOrWhiteSpace(Förnamn))
            felmeddelande += "Förnamn saknas\n";

        if (string.IsNullOrWhiteSpace(Efternamn))
            felmeddelande += "Efternamn saknas\n";

        if (string.IsNullOrWhiteSpace(Email))
            felmeddelande += "Email saknas\n";

        if (string.IsNullOrWhiteSpace(Telefonnummer))
            felmeddelande += "Telefonnummer saknas\n";

        if (string.IsNullOrEmpty(felmeddelande))
            return "OK";

        return felmeddelande;
    }

    public string HamtaBetyg()
    {
        var betygLists = new List<(string kurs, string betyg)>
        {
            ("Programmering C#", "G"),
            ("Databasteknik", "VG"),
            ("Webbutveckling", "IG"),
        };
        string resultat = "";

        foreach (var (k, b) in betygLists)
        {
            resultat += $"Kurs: {k}, Betyg: {b}\n";
        }
        return resultat;
    }

    public void RensaUppgifter()
    {
        Förnamn = "";
        Efternamn = "";
        Email = "";
        Telefonnummer = "";
    }

    public string SammanFattning()
    {
        return $"{Förnamn}, {Efternamn}, {Email}, {Telefonnummer}";
    }

    // public override string ToString()// detta är samma metod som SammanFattning
    // {
    //     return $"{Förnamn}, {Efternamn}, {Email}, {Telefonnummer}";
    // }
}
