namespace Task2;

public class PremiumMembership : Membership
{
    private const decimal PersonalSessionPrice = 250m;

    public int PersonalSessionsPerMonth { get; }

    public PremiumMembership(string memberName, decimal baseFee, int personalSessionsPerMonth)
        : base(memberName, baseFee)
    {
        PersonalSessionsPerMonth = personalSessionsPerMonth;
        Trace("конструктор PremiumMembership");
    }

    public override string Category => "Преміум";

    public override decimal CalculateMonthlyFee() =>
        BaseFee + PersonalSessionsPerMonth * PersonalSessionPrice;

    public override int GetFreezeDaysPerYear() => 60;
}
