namespace ProductsApp.Models;

// Клас-нащадок "Книги"
public class Book : Product
{
    public int Pages { get; set; }                                  // Кількість сторінок
    public string Publisher { get; set; } = string.Empty;           // Видавництво
    public List<string> Authors { get; set; } = new();              // Перелік авторів

    public override string Category => "Книга";

    public override string Details =>
        $"{Pages} стор.; {Publisher}; автори: {string.Join(", ", Authors)}";
}