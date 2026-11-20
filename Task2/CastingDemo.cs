namespace Task2;

public static class CastingDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Завдання 3: is, as та приведення типів ===");
        Console.WriteLine();

        List<Membership> members = SampleData.CreateMembers();
        members.Add(new StudentMembership("Тарас Лис", 800m, "Університет", new DateOnly(2026, 6, 30)));

        Console.WriteLine("--- Колекція (елементи оголошені як Membership) ---");
        foreach (Membership m in members)
            Console.WriteLine($"   {m.GetType().Name.PadRight(22)}{m.MemberName}");

        Console.WriteLine();
        Console.WriteLine("--- is з оголошенням змінної: лише PremiumMembership ---");
        foreach (Membership m in members)
        {
            if (m is PremiumMembership premium)
                Console.WriteLine($"   {premium.MemberName}: персональних тренувань на місяць — {premium.PersonalSessionsPerMonth}");
        }

        Console.WriteLine();
        Console.WriteLine("--- as з перевіркою на null: лише StudentMembership ---");
        foreach (Membership m in members)
        {
            StudentMembership? student = m as StudentMembership;
            if (student != null)
                Console.WriteLine($"   {student.MemberName}: {student.University}");
            else
                Console.WriteLine($"   {m.MemberName}: as повернув null ({m.GetType().Name})");
        }

        Console.WriteLine();
        Console.WriteLine("--- Член, якого немає в контракті бази: IsStudyStatusValid ---");
        DateOnly today = new(2026, 11, 20);
        foreach (Membership m in members)
        {
            // СКРІН 3: розкоментуйте наступний рядок — буде помилка CS1061
            // bool check = m.IsStudyStatusValid(today);

            if (m is StudentMembership s)
            {
                string status = s.IsStudyStatusValid(today) ? "підтверджено" : "ПРОСТРОЧЕНО";
                Console.WriteLine($"   {s.MemberName}: статус студента на {today:dd.MM.yyyy} — {status}");
            }
        }
    }
}
