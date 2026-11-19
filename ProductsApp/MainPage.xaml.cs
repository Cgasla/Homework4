using System.Collections.ObjectModel;
using System.Globalization;
using ProductsApp.Models;

namespace ProductsApp;

public partial class MainPage : ContentPage
{
    // ObservableCollection сама повідомляє таблицю про додавання/видалення
    private readonly ObservableCollection<Product> _products = new();

    public MainPage()
    {
        InitializeComponent();
        FillSampleData();
        ProductsView.ItemsSource = _products;
    }

    // Початкове заповнення таблиці
    private void FillSampleData()
    {
        _products.Add(new FoodProduct
        {
            Name = "Молоко",
            Price = 42.50m,
            CountryOfOrigin = "Україна",
            PackingDate = DateTime.Today.AddDays(-1),
            Description = "Молоко 2.5%",
            ExpirationDate = DateTime.Today.AddDays(6),
            Quantity = 1,
            Unit = "л"
        });

        _products.Add(new FoodProduct
        {
            Name = "Сир",
            Price = 180m,
            CountryOfOrigin = "Нідерланди",
            PackingDate = DateTime.Today.AddDays(-5),
            Description = "Твердий сир Гауда",
            ExpirationDate = DateTime.Today.AddDays(60),
            Quantity = 0.5,
            Unit = "кг"
        });

        _products.Add(new Book
        {
            Name = "Кобзар",
            Price = 250m,
            CountryOfOrigin = "Україна",
            PackingDate = DateTime.Today.AddDays(-30),
            Description = "Збірка поезій",
            Pages = 480,
            Publisher = "Видавництво Старого Лева",
            Authors = new List<string> { "Тарас Шевченко" }
        });

        _products.Add(new Book
        {
            Name = "Тіні забутих предків",
            Price = 150m,
            CountryOfOrigin = "Україна",
            PackingDate = DateTime.Today.AddDays(-20),
            Description = "Повість",
            Pages = 160,
            Publisher = "Ранок",
            Authors = new List<string> { "Михайло Коцюбинський" }
        });
    }

    // Кнопка "Додати товар"
    private async void OnAddClicked(object? sender, EventArgs e)
    {
        // 1. Вибір типу товару
        string type = await DisplayActionSheet(
            "Що додати?", "Скасувати", null, "Продукт", "Книга");

        if (type != "Продукт" && type != "Книга")
            return;

        // 2. Назва
        string? name = await DisplayPromptAsync("Назва", "Введіть назву товару:");
        if (string.IsNullOrWhiteSpace(name))
            return;

        // 3. Ціна
        string? priceText = await DisplayPromptAsync(
            "Ціна", "Введіть ціну (грн):",
            keyboard: Keyboard.Numeric, initialValue: "100");

        decimal.TryParse(priceText?.Replace(',', '.'),
            NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price);

        // 4. Створення об'єкта потрібного типу
        if (type == "Продукт")
        {
            _products.Add(new FoodProduct
            {
                Name = name,
                Price = price,
                CountryOfOrigin = "Україна",
                PackingDate = DateTime.Today,
                Description = "Доданий вручну",
                ExpirationDate = DateTime.Today.AddDays(14),
                Quantity = 1,
                Unit = "шт"
            });
        }
        else
        {
            _products.Add(new Book
            {
                Name = name,
                Price = price,
                CountryOfOrigin = "Україна",
                PackingDate = DateTime.Today,
                Description = "Додана вручну",
                Pages = 200,
                Publisher = "Невідоме видавництво",
                Authors = new List<string> { "Невідомий автор" }
            });
        }
    }

    // Кнопка "Видалити вибраний"
    private async void OnDeleteClicked(object? sender, EventArgs e)
    {
        if (ProductsView.SelectedItem is Product selected)
        {
            bool confirm = await DisplayAlert(
                "Підтвердження", $"Видалити «{selected.Name}»?", "Так", "Ні");

            if (confirm)
                _products.Remove(selected);
        }
        else
        {
            await DisplayAlert("Увага", "Спочатку виберіть товар у таблиці.", "OK");
        }
    }
}