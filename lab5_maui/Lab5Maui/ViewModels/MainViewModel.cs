using System;
using System.Collections.ObjectModel;  
using Lab5Maui.Models;

namespace Lab5Maui.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Product> Items { get; } = new();

        public MainViewModel()
        {
            Items.Add(new FoodProduct {
                Name = "Milk 2.5%", Price = 35, CountryOfOrigin = "UA",
                PackingDate = DateTime.Today.AddDays(-1),
                Description = "Dairy",
                ExpirationDate = DateTime.Today.AddDays(5),
                Quantity = 1, Unit = "L"
            });

            Items.Add(new Book {
                Name = "Clean Code", Price = 650, CountryOfOrigin = "UA",
                PackingDate = DateTime.Today,
                Description = "Programming",
                Pages = 464, Publisher = "Prentice Hall", Authors = { "Robert C. Martin" }
            });
        }

        public void AddSample()
        {
            Items.Add(new FoodProduct {
                Name = "Bread", Price = 25, CountryOfOrigin = "UA",
                PackingDate = DateTime.Today,
                Description = "Bakery",
                ExpirationDate = DateTime.Today.AddDays(3),
                Quantity = 1, Unit = "pc"
            });
        }

        public void RemoveLast()
        {
            if (Items.Count > 0) Items.RemoveAt(Items.Count - 1);
        }
    }
}