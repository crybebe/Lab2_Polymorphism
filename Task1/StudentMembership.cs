namespace Task1;

public class StudentMembership : Membership
{
    public string University { get; }

    public StudentMembership(string memberName, decimal baseFee, string university)
        : base(memberName, baseFee)
    {
        University = university;
    }

    // Знижка 40 % для студентів
    public override decimal CalculateMonthlyFee() => BaseFee * 0.6m;

    public override string GetDescription() =>
        $"Студентський абонемент ({University}): {CalculateMonthlyFee():F2} грн/міс";

    // GetFreezeDaysPerYear() тут НЕ перевизначено — діє реалізація з Membership
}
