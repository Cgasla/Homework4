namespace GeoInterface;

// Інтерфейс "Географічний об'єкт"
public interface IGeographicObject
{
    double X { get; set; }
    double Y { get; set; }
    string Name { get; set; }
    string Description { get; set; }

    // Метод отримання інформації
    string GetInformation();
}