public class Lektion
{
    public string Kurs { get; set; }
    public DateTime Datum { get; set; }
    public string Klassrum { get; set; }

    public bool Boka()
    {
        if (
            string.IsNullOrWhiteSpace(Kurs)
            || Datum == default
            || string.IsNullOrWhiteSpace(Klassrum)
        )
        {
            Console.WriteLine("Det fattas uppgifter");
            return false;
        }
        else
        {
            Console.WriteLine("Alla uppgifter är satta");
            return true;
        }
    }

    public bool TaBort()
    {
        if (!string.IsNullOrWhiteSpace(Kurs) && !string.IsNullOrWhiteSpace(Klassrum))
        {
            Console.WriteLine("Kurs och Klassrum är satta");
            return true;
        }
        Console.WriteLine("Kurs och Klassrum är EJ satta");
        return false;
    }
}
