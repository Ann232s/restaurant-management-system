using System;

namespace RestaurantSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование рефакторинга Recipe класса");
          
            var recipe = new Recipe
            {
                Name = "Суп",
                Price = 500,
                Ingredients = new List<Ingredient>
                {
                    new Ingredient 
                    { 
                        Product = new Product { Price = 100 },
                        Quantity = 2 
                    }
                }
            };
            
            recipe.CalculateCostPrice();
            Console.WriteLine($"Себестоимость: {recipe.CostPrice}");
        }
    }
}