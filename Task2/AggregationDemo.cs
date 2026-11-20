namespace Task2;

public static class AggregationDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Завдання 4: колекції та узагальнені операції ===");
        Console.WriteLine();

        List<Membership> members = SampleData.CreateMembers();

        Console.WriteLine("--- Пункт 1: Summarize (через контракт Membership) ---");
        Print(MembershipStats.Summarize(members));

        Console.WriteLine();
        Console.WriteLine("--- Пункт 2: фільтрація за фактичним типом (OfType) ---");
        List<PremiumMembership> premiums = members.OfType<PremiumMembership>().ToList();
        Console.WriteLine($"Преміум-абонементів: {premiums.Count}");
        foreach (PremiumMembership p in premiums)
            Console.WriteLine($"   {p.MemberName}: {p.PersonalSessionsPerMonth} персональних тренувань/міс");

        Console.WriteLine();
        Console.WriteLine("--- Пункт 3: додано новий підтип CorporateMembership ---");
        members.Add(new CorporateMembership("ТОВ «Альфа»", 800m, 25));
        members.Add(new CorporateMembership("ФОП Дмитренко", 800m, 4));
        Print(MembershipStats.Summarize(members));   // той самий виклик, текст Summarize не змінювався
        Console.WriteLine($"Корпоративних абонементів: {members.OfType<CorporateMembership>().Count()}");
    }

    private static void Print(FeeSummary s) =>
        Console.WriteLine($"Кількість: {s.Count}, сума: {s.Total:F2}, середнє: {s.Average:F2}, максимум: {s.Max:F2}");
}
