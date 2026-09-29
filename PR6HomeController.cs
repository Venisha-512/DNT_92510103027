using Microsoft.AspNetCore.Mvc;
using p6.Models;
using System.Linq.Expressions;

namespace p6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = GetProducts();

            return View(products);
        }

        public IActionResult Details(int id)
        {
            List<Product> products = GetProducts();
            Product product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }
        private List<Product> GetProducts()
        {

            List<Product> p = new List<Product>();

            Product p1 = new Product
            {
                Id = 1,
                Category = "Electronics",
                Name = "Smartphone",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcToQyROcR5bClt7s1HCpIa8kc55LYFuMmf3JbMn4LgwtQ&s=10",
                Description = "A high-end smartphone with a great camera.",
                Price = 999.99m
            };

            Product p2 = new Product
            {
                Id = 2,
                Category = "Electronics",
                Name = "Laptop",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2QgzOcNrJS09f_xO1b5wEc94uC4jFXSUi9NwF3mGGWg&s=10",
                Description = "A powerful laptop for work and play.",
                Price = 1499.99m
            };

            Product p3 = new Product
            {
                Id = 3,
                Category = "Home Appliances",
                Name = "Vacuum Cleaner",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ7oL4eMzRNLsVDjuY0Z07aNISvpnj7qqVzxHUvxpU84w&s=10",
                Description = "A lightweight vacuum cleaner for easy cleaning.",
                Price = 199.99m
            };

            p.Add(p1);
            p.Add(p2);
            p.Add(p3);

            return p;
}

        }
    }
