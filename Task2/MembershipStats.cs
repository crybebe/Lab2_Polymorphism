namespace Task2;

public readonly record struct FeeSummary(int Count, decimal Total, decimal Average, decimal Max);

public static class MembershipStats
{
    // Узагальнена процедура: працює ЛИШЕ через контракт Membership,
    // без перевірок конкретних типів (жодних is / as / if по типах).
    public static FeeSummary Summarize(IEnumerable<Membership> memberships)
    {
        int count = 0;
        decimal total = 0m;
        decimal max = 0m;

        foreach (Membership m in memberships)
        {
            decimal fee = m.CalculateMonthlyFee();
            count++;
            total += fee;
            if (fee > max) max = fee;
        }

        return new FeeSummary(count, total, count == 0 ? 0m : total / count, max);
    }
}
