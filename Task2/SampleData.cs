namespace Task2;

public static class SampleData
{
    public static List<Membership> CreateMembers() => new()
    {
        new StandardMembership("Олена Коваль", 800m, offPeakOnly: true),
        new PremiumMembership("Андрій Мельник", 1500m, personalSessionsPerMonth: 4),
        new StudentMembership("Ірина Шевчук", 800m, "Університет", new DateOnly(2027, 6, 30)),
        new StandardMembership("Максим Бондар", 800m, offPeakOnly: false),
        new PremiumMembership("Софія Гнатюк", 1500m, personalSessionsPerMonth: 8),
    };
}
