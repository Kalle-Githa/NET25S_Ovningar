using System.IO.Pipelines;

public class Klassrum
{
    public int AntalStolar { get; set; }
    public double Yta { get; set; }
    public List<Lektion> Lektioner { get; set; } = new List<Lektion>();

    public bool KontrolleraStorlek(double minYta)
    {
        // if (minYta <= Yta) // if sats behövs inte då denna metod redan returnerar en bool
        // {
        //     return true;
        // }
        // return false;
        return Yta >= minYta;
    }

    public List<Lektion> HamtaLektioner() // bättre att retunera detta än försöka displaya resultat detta görs i program.cs isället
    {
        return Lektioner;
    }

    public bool KontrolleraLedigt(DateTime startDatum)
    {
        foreach (var l in Lektioner)
        {
            if (l.Datum == startDatum)
            {
                return false;
            }
        }
        return true;
    }
}
