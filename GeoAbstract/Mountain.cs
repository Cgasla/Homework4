namespace GeoAbstract;

public class Mountain : GeographicObject
{
    public double HighestPoint { get; set; }   // Найвища точка (м)

    public Mountain(double x, double y, string name, string description,
                    double highestPoint)
        : base(x, y, name, description)
    {
        HighestPoint = highestPoint;
    }

    public override string GetInformation()
    {
        return $"[Гора] {base.GetInformation()}; найвища точка: {HighestPoint} м";
    }
}