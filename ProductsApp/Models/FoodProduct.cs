namespace ProductsApp.Models;

// Клас-нащадок "Продукти"
public class FoodProduct : Product
{
    public DateTime ExpirationDate { get; set; }    // Термін придатності
    public double Quantity { get; set; }            // Кількість
    public string Unit { get; set; } = string.Empty; // Одиниця виміру

    public override string Category => "Продукт";

    public override string Details =>
        $"Придатний до {ExpirationDate:dd.MM.yyyy}; {Quantity} {Unit}";
}