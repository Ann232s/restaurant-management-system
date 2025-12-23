using System;
using System.Collections.Generic;

namespace RestaurantSystem
{
    public class ConditionalExamples
    {
        // Пример 1: Сложный условный оператор для декомпозиции
        public string GetDishCategory(int cookingTime, decimal price, bool isVegetarian)
        {
            if (IsPremiumMeatDish(cookingTime, price, isVegetarian))
                return "Премиум мясное блюдо";

            if (IsLightVegetarianDish(cookingTime, price, isVegetarian))
                return "Лёгкое вегетарианское";

            if (IsComplexDish(cookingTime, price))
                return "Сложное в приготовлении";

            return "Обычное блюдо";
        }

        private bool IsPremiumMeatDish(int cookingTime, decimal price, bool isVegetarian)
        {
            return cookingTime > 60 && price > 500 && !isVegetarian;
        }

        private bool IsLightVegetarianDish(int cookingTime, decimal price, bool isVegetarian)
        {
            return cookingTime <= 30 && price < 300 && isVegetarian;
        }

        private bool IsComplexDish(int cookingTime, decimal price)
        {
            return cookingTime > 45 && price > 400;
        }

        // Пример 2: Несколько условий для консолидации
        public bool CanOrderDish(int time, bool kitchenOpen, bool ingredientsAvailable, bool chefAvailable)
        {
            return IsWorkingTime(time) &&
                   kitchenOpen &&
                   ingredientsAvailable &&
                   chefAvailable;
        }

        private bool IsWorkingTime(int time)
        {
            return time >= 10 && time <= 22;
        }

        // Пример 3: Дублирующиеся условные фрагменты
        public decimal CalculateDiscount(bool isRegularCustomer, int orderCount, decimal totalAmount)
        {
            decimal discount = 0;
            
            if (isRegularCustomer)
            {
                if (orderCount > 10)
                {
                    discount = totalAmount * 0.15m;
                    // Дублирующийся код
                    Console.WriteLine("Применена скидка");
                    LogDiscount("regular", 0.15m);
                }
                else if (orderCount > 5)
                {
                    discount = totalAmount * 0.10m;
                    // Дублирующийся код
                    Console.WriteLine("Применена скидка");
                    LogDiscount("regular", 0.10m);
                }
                else if (orderCount > 2)
                {
                    discount = totalAmount * 0.05m;
                    // Дублирующийся код
                    Console.WriteLine("Применена скидка");
                    LogDiscount("regular", 0.05m);
                }
            }
            else
            {
                if (totalAmount > 5000)
                {
                    discount = totalAmount * 0.05m;
                    Console.WriteLine("Применена скидка");
                    LogDiscount("new", 0.05m);
                }
            }
            
            return discount;
        }

        // Пример 4: Управляющий флаг
        public bool ProcessOrder(List<string> dishes)
        {
            bool orderProcessed = false; // Управляющий флаг
            bool paymentReceived = false;
            bool kitchenAccepted = false;
            
            foreach (var dish in dishes)
            {
                if (!CheckIngredients(dish))
                {
                    orderProcessed = false;
                    break;
                }
                
                if (!CheckCookingTime(dish))
                {
                    orderProcessed = false;
                    break;
                }
                
                kitchenAccepted = true;
            }
            
            if (kitchenAccepted)
            {
                paymentReceived = ProcessPayment();
                
                if (paymentReceived)
                {
                    orderProcessed = true;
                }
                else
                {
                    orderProcessed = false;
                }
            }
            
            return orderProcessed;
        }

        // Вспомогательные методы
        private void LogDiscount(string customerType, decimal discountRate)
        {
            // Заглушка для логирования
        }
        
        private bool CheckIngredients(string dish)
        {
            return true; // Заглушка
        }
        
        private bool CheckCookingTime(string dish)
        {
            return true; // Заглушка
        }
        
        private bool ProcessPayment()
        {
            return true; // Заглушка
        }
    }
}