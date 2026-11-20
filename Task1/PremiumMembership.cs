namespace Task1;

public class PremiumMembership : Membership
{
    private const decimal PersonalSessionPrice = 250m;

    public int PersonalSessionsPerMonth { get; }

    public PremiumMembership(string memberName, decimal baseFee, int personalSessionsPerMonth)
        : base(memberName, baseFee)
    {
        PersonalSessionsPerMonth = personalSessionsPerMonth;
    }

    // Базовий тариф + оплата персональних тренувань
    public override decimal CalculateMonthlyFee() =>
        BaseFee + PersonalSessionsPerMonth * PersonalSessionPrice;

    public override string GetDescription() =>
        $"Преміум-абонемент (+{PersonalSessionsPerMonth} персональних тренувань): {CalculateMonthlyFee():F2} грн/міс";

    // Перевизначає і метод із реалізацією за замовчуванням
    public override int GetFreezeDaysPerYear() => 60;
}
