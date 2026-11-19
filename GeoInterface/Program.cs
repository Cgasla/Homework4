using GeoInterface;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<IGeographicObject> objects = new()
{
    new River(30.52, 50.45, "Дніпро", "Найбільша річка України", 50, 2201),
    new Mountain(24.50, 48.16, "Говерла", "Найвища гора Українських Карпат", 2061)
};

foreach (IGeographicObject obj in objects)
{
    Console.WriteLine(obj.GetInformation());
}

Console.ReadKey();