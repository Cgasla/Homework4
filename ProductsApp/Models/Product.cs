namespace ProductsApp.Models;

// Базовий клас "Товар"
public class Product
{
    public string Name { get; set; } = string.Empty;              // Назва
    public decimal Price { get; set; }                            // Ціна
    public string CountryOfOrigin { get; set; } = string.Empty;   // Країна походження
    public DateTime PackingDate { get; set; }                     // Дата пакування
    public string Description { get; set; } = string.Empty;       // Опис

    // Віртуальні властивості - для відображення в таблиці
    public virtual string Category => "Товар";
    public virtual string Details => string.Empty;
}