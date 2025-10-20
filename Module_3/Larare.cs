public class Larare
{
    // 🧩 Egenskaper (properties) istället för fält ifall i framtiden ger det dig möjlighet att lägga till t.ex. validering eller skydd mot direkt åtkomst.
    public string Namn { get; set; }
    public string Email { get; set; }
    public string Telefon { get; set; }

    public List<string> AnsvarigForKurser()
    {
        // var kursLista =

        // string allaKurser = "";
        // foreach (var k in kursLista)
        // {
        //     allaKurser += $"Kurs: {k}\n";
        // }
        return HamtaKurser();
    }

    private List<string> HamtaKurser()
    {
        var kursLista = new List<string> { "Programmering", "Datavetenskap", "Dotnet" };
        return kursLista;
    }

    public string SammanFattning()
    {
        return $"{Namn}, {Email}, {Telefon}";
    }
}
