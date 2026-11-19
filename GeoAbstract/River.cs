namespace GeoAbstract;

public class River : GeographicObject
{
    public double FlowSpeed { get; set; }   // Швидкість течії (см/с)
    public double Length { get; set; }      // Загальна довжина (км)

    public River(double x, double y, string name, string description,
                 double flowSpeed, double length)
        : base(x, y, name, description)
    {
        FlowSpeed = flowSpeed;
        Length = length;
    }

    // Перевизначаємо віртуальний метод
    public override string GetInformation()
    {
        return $"[Річка] {base.GetInformation()}; " +
               $"швидкість течії: {FlowSpeed} см/с; довжина: {Length} км";
    }
}