namespace Task1;

public class StandardMembership : Membership
{
    public bool OffPeakOnly { get; }

    public StandardMembership(string memberName, decimal baseFee, bool offPeakOnly)
        : base(memberName, baseFee)
    {
        OffPeakOnly = offPeakOnly;
    }

    // Знижка 20 %, якщо відвідування лише в непіковий час
    public override decimal CalculateMonthlyFee() => OffPeakOnly ? BaseFee * 0.8m : BaseFee;

    public override string GetDescription()
    {
        string schedule = OffPeakOnly ? "лише у непіковий час" : "без обмежень за часом";
        return $"Стандартний абонемент ({schedule}): {CalculateMonthlyFee():F2} грн/міс";
    }
}
