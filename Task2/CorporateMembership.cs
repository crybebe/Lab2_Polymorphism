namespace Task2;

// Новий підтип для Завдання 4 (додається окремим файлом, решта коду не змінюється)
public class CorporateMembership : Membership
{
    public int EmployeesCount { get; }

    public CorporateMembership(string companyName, decimal baseFee, int employeesCount)
        : base(companyName, baseFee)
    {
        EmployeesCount = employeesCount;
    }

    public override string Category => "Корпоративний";

    // Знижка 30 % для великих компаній (від 10 працівників), інакше 15 %
    public override decimal CalculateMonthlyFee() =>
        BaseFee * (EmployeesCount >= 10 ? 0.7m : 0.85m);
}
