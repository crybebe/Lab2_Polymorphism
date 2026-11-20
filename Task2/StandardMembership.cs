namespace Task2;

public class StandardMembership : Membership
{
    public bool OffPeakOnly { get; }

    public StandardMembership(string memberName, decimal baseFee, bool offPeakOnly)
        : base(memberName, baseFee)
    {
        OffPeakOnly = offPeakOnly;
        Trace("конструктор StandardMembership");
    }

    public override string Category => "Стандарт";

    public override decimal CalculateMonthlyFee() => OffPeakOnly ? BaseFee * 0.8m : BaseFee;
}
