using System;

namespace RestaurantSystem
{
    // Базовый класс - сотрудник ресторана
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        
        // Метод, который будет подниматься
        public void PrintBasicInfo()
        {
            Console.WriteLine($"Сотрудник: {Name}");
            Console.WriteLine($"Должность: {Position}");
        }
        
        // Поле, которое будет подниматься
        protected string restaurantName = "Ресторан 'Вкус Востока'";
    }

    // Класс Шеф-повар
    public class Chef : Employee
    {
        public string Specialization { get; set; }
        
        // Дублирующийся метод (должен быть в базовом классе)
        public void PrintChefInfo()
        {
            Console.WriteLine($"Сотрудник: {Name}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Специализация: {Specialization}");
        }
        
        // Метод, который должен спускаться в подклассы
        public void CookDish(string dishName)
        {
            Console.WriteLine($"{Name} готовит {dishName} в {restaurantName}");
        }
    }

    // Класс Официант
    public class Waiter : Employee
    {
        public int TablesCount { get; set; }
        
        // Дублирующийся метод (должен быть в базовом классе)
        public void PrintWaiterInfo()
        {
            Console.WriteLine($"Сотрудник: {Name}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Количество столов: {TablesCount}");
        }
        
        // Метод, который должен спускаться в подклассы
        public void ServeTable(int tableNumber)
        {
            Console.WriteLine($"{Name} обслуживает стол {tableNumber} в {restaurantName}");
        }
        
        // Поле, которое дублируется (должно быть в базовом классе)
        protected string shiftSchedule = "Дневная смена";
    }

    // Класс Управляющий
    public class Manager : Employee
    {
        public string Department { get; set; }
        
        // Дублирующийся метод (должен быть в базовом классе)
        public void PrintManagerInfo()
        {
            Console.WriteLine($"Сотрудник: {Name}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Отдел: {Department}");
        }
        
        // Поле, которое дублируется (должно быть в базовом классе)
        protected string shiftSchedule = "Дневная смена";
    }

    // Класс для примера подъёма поля
    public class MenuItem
    {
        // Поля, которые дублируются в подклассах
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        // Поле для подъёма
        protected int calories = 0;
    }

    public class Drink : MenuItem
    {
        public decimal Volume { get; set; }
        
        // Дублирующееся поле (должно быть в базовом классе)
        protected int calories = 150;
        
        public void ShowDrinkInfo()
        {
            Console.WriteLine($"Напиток: {Name}, {Volume} мл, {calories} ккал");
        }
    }

    public class Dish : MenuItem
    {
        public int CookingTime { get; set; }
        
        // Дублирующееся поле (должно быть в базовом классе)
        protected int calories = 350;
        
        public void ShowDishInfo()
        {
            Console.WriteLine($"Блюдо: {Name}, {CookingTime} мин, {calories} ккал");
        }
    }
}
