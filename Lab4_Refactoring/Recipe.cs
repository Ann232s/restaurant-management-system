using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantSystem
{
    public class Ingredient
    {
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
    }

    public class Product
    {
        public decimal Price { get; set; }
    }

    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal CostPrice { get; private set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public void CalculateCostPrice()
        {
            CostPrice = CalculateIngredientsTotalCost();
        }

        private decimal CalculateIngredientsTotalCost()
        {
            decimal total = 0;
            foreach (var ingredient in Ingredients)
            {
                total += CalculateIngredientCost(ingredient);
            }
            return total;
        }

        private decimal CalculateIngredientCost(Ingredient ingredient)
        {
            return ingredient.Product.Price * ingredient.Quantity;
        }

        public void SetPriceWithMarkup(decimal markupPercent)
        {
            Price = CostPrice * (1 + markupPercent / 100);
        }

        public bool CanBeActivated()
        {
            return Ingredients.Count > 0 && CostPrice > 0;
        }

        public decimal GetPriceWithTax()
        {
            return CalculatePriceWithTax(Price, 0.2m);
        }

        private decimal CalculatePriceWithTax(decimal price, decimal taxRate)
        {
            return price * (1 + taxRate);
        }

        public decimal CalculateProfitPerServing(decimal sellingPrice, decimal taxRate)
        {

            return sellingPrice - CostPrice;
        }

        public void ApplyMarkupPercent(decimal markupPercent)
        {
            Price = CostPrice * (1 + markupPercent / 100);
        }
    }
}