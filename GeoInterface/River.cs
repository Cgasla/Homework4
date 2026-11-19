namespace GeoInterface;

public class River : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double FlowSpeed { get; set; }   // см/с
    public double Length { get; set; }      // км

    public River(double x, double y, string name, string description,
                 double flowSpeed, double length)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
        FlowSpeed = flowSpeed;
        Length = length;
    }

    public string GetInformation()
    {
        return $"[Річка] {Name} (X={X}; Y={Y}) - {Description}; " +
               $"швидкість течії: {FlowSpeed} см/с; довжина: {Length} км";
    }
}