public class Medelande
{
    public string Text { get; set; }

    public string VisaMedelande()
    {
        return $"Hello World {Text}";
    }
}
