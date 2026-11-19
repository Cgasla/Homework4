namespace GeoAbstract;

// Абстрактний клас "Географічний об'єкт"
public abstract class GeographicObject
{
    public double X { get; set; }              // Координата Х
    public double Y { get; set; }              // Координата У
    public string Name { get; set; }           // Назва
    public string Description { get; set; }    // Опис

    protected GeographicObject(double x, double y, string name, string description)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
    }

    // "Метод отримання інформації" - віртуальний
    public virtual string GetInformation()
    {
        return $"{Name} (X={X}; Y={Y}) - {Description}";
    }
}