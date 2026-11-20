using Task1;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Повертає ім'я класу, у якому оголошена реалізація методу, що реально виконується
static string Implementer(Membership m, string methodName) =>
    m.GetType().GetMethod(methodName)!.DeclaringType!.Name;

// Змінна/колекція має тип БАЗОВОГО класу, а об'єкти — різних похідних
Membership[] members =
{
    new StandardMembership("Олена Коваль", 800m, offPeakOnly: true),
    new PremiumMembership("Андрій Мельник", 1500m, personalSessionsPerMonth: 4),
    new StudentMembership("Ірина Шевчук", 800m, "Університет"),
    new StandardMembership("Максим Бондар", 800m, offPeakOnly: false),
};

Console.WriteLine("=== Завдання 1: поліморфний обхід колекції Membership[] ===");
Console.WriteLine();
foreach (Membership m in members)
{
    Console.WriteLine($"{m.MemberName}  (тип змінної: Membership, фактичний тип: {m.GetType().Name})");
    Console.WriteLine($"   CalculateMonthlyFee()  = {m.CalculateMonthlyFee():F2} грн");
    Console.WriteLine($"   GetDescription()       = {m.GetDescription()}");
    Console.WriteLine($"   GetFreezeDaysPerYear() = {m.GetFreezeDaysPerYear()} днів");
}

Console.WriteLine();
Console.WriteLine("=== Яка реалізація виконалася (клас, що містить виконаний код) ===");
Console.WriteLine(
    "Елемент".PadRight(16) + "Фактичний тип".PadRight(20) +
    "CalculateMonthlyFee".PadRight(22) + "GetDescription".PadRight(20) + "GetFreezeDaysPerYear");
foreach (Membership m in members)
{
    Console.WriteLine(
        m.MemberName.PadRight(16) +
        m.GetType().Name.PadRight(20) +
        Implementer(m, nameof(Membership.CalculateMonthlyFee)).PadRight(22) +
        Implementer(m, nameof(Membership.GetDescription)).PadRight(20) +
        Implementer(m, nameof(Membership.GetFreezeDaysPerYear)));
}
