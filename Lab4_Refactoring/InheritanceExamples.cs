using System;

namespace RestaurantSystem
{
    // Базовый класс - сотрудник ресторана

    public abstract class Employee  // делаем класс абстрактным
    {
        // ... свойства ...

        // Абстрактный метод (каждый сотрудник выполняет свою работу)
        public abstract void PerformWork();
    }

    public class Chef : Employee
    {
        public override void PerformWork()
        {
            Console.WriteLine($"{Name} готовит блюда в {restaurantName}");
        }

        // Конкретный метод только для шефа
        public void CookDish(string dishName)
        {
            Console.WriteLine($"{Name} готовит {dishName}");
        }
    }

    public class Waiter : Employee
    {
        public override void PerformWork()
        {
            Console.WriteLine($"{Name} обслуживает клиентов");
        }

        // Конкретный метод только для официанта
        public void ServeTable(int tableNumber)
        {
            Console.WriteLine($"{Name} обслуживает стол {tableNumber}");
        }
    }

    public class Waiter : Employee
    {
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Количество столов: {TablesCount}");
        }
    }

    public class Manager : Employee
    {
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Отдел: {Department}");
        }
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
      
            // ПОДНЯТОЕ ПОЛЕ
            protected string shiftSchedule = "Дневная смена";

            public string GetShiftSchedule() => shiftSchedule;
            public void SetShiftSchedule(string schedule) => shiftSchedule = schedule;
        }
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
public abstract class MenuItem  // делаем абстрактным
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    // Абстрактное свойство (каждый подкласс определяет свою калорийность)
    public abstract int Calories { get; }
}

public class Drink : MenuItem
{
    public decimal Volume { get; set; }

    // Реализуем свойство
    public override int Calories => 150;

    public void ShowDrinkInfo()
    {
        Console.WriteLine($"Напиток: {Name}, {Volume} мл, {Calories} ккал");
    }
}

public class Dish : MenuItem
{
    public int CookingTime { get; set; }

    // Реализуем свойство
    public override int Calories => 350;

    public void ShowDishInfo()
    {
        Console.WriteLine($"Блюдо: {Name}, {CookingTime} мин, {Calories} ккал");
    }
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
