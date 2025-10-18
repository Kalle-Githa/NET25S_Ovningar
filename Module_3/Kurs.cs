using System.Runtime.InteropServices;

public class Kurs
{
    public string KursNamn { get; set; }

    public DateTime StartDatum { get; set; }
    public DateTime SlutDatum { get; set; }
    public int Poäng { get; set; }

    public double BeraknaAntalKursDagar()
    {
        TimeSpan result = SlutDatum - StartDatum;
        return result.TotalDays;
    }

    public float PoangPerKursdag()
    {
        float poangPerKursdag = Poäng / (float)BeraknaAntalKursDagar();
        return poangPerKursdag;
    }
}
