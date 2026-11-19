namespace GeoInterface;

public class Mountain : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double HighestPoint { get; set; }   // м

    public Mountain(double x, double y, string name, string description,
                    double highestPoint)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
        HighestPoint = highestPoint;
    }

    public string GetInformation()
    {
        return $"[Гора] {Name} (X={X}; Y={Y}) - {Description}; " +
               $"найвища точка: {HighestPoint} м";
    }
}