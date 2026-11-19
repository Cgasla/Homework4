using GeoAbstract;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Список базового типу - зберігає і річки, і гори
List<GeographicObject> objects = new()
{
    new River(30.52, 50.45, "Дніпро", "Найбільша річка України", 50, 2201),
    new River(24.03, 49.84, "Дністер", "Річка на заході України", 40, 1362),
    new Mountain(24.50, 48.16, "Говерла", "Найвища гора Українських Карпат", 2061)
};

foreach (GeographicObject obj in objects)
{
    // Викликається перевизначений метод конкретного класу (поліморфізм)
    Console.WriteLine(obj.GetInformation());
}

Console.ReadKey();