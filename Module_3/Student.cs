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
        List<string> betygProgrammering = ["Programmering C#", "G"];
        List<string> betygDatabaser = ["Databasteknik", "VG"];
        List<string> betygWebbutveckling = ["Webbutveckling", "IG"];
        return $"{betygProgrammering[0]}: {betygProgrammering[1]}\n{betygDatabaser[0]}: {betygDatabaser[1]}\n{betygWebbutveckling[0]}: {betygWebbutveckling[1]}";
    }

    // public override string ToString()
    // {
    //     return $"{Förnamn}, {Efternamn}, {Email}, {Telefonnummer}";
    // }
}
