namespace Task2;

public static class AbstractionDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Завдання 2: абстрактний клас ===");
        Console.WriteLine();

        Console.WriteLine("Створення StudentMembership (ланцюжок base(...)):");
        Membership.TraceConstruction = true;
        var student = new StudentMembership("Ірина Шевчук", 800m, "Університет", new DateOnly(2027, 6, 30));
        Membership.TraceConstruction = false;

        Console.WriteLine();
        Console.WriteLine($"Category (абстрактна властивість)      = {student.Category}");
        Console.WriteLine($"CalculateMonthlyFee() (абстр. метод)   = {student.CalculateMonthlyFee():F2} грн");
        Console.WriteLine($"GetDescription() (віртуальний у базі)  = {student.GetDescription()}");
        Console.WriteLine($"typeof(Membership).IsAbstract          = {typeof(Membership).IsAbstract}");

        // СКРІН 3: розкоментуйте наступний рядок — буде помилка CS0144
        //var forbidden = new Membership("Тест", 100m);
    }
}
