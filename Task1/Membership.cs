namespace Task1;

// Неабстрактний базовий клас предметної області «Абонементи спортивного клубу»
public abstract class Membership
{
    public string MemberName { get; }
    protected decimal BaseFee { get; }

    public Membership(string memberName, decimal baseFee)
    {
        MemberName = memberName;
        BaseFee = baseFee;
    }

    // Віртуальний метод 1: розрахунок місячного внеску
    public abstract decimal CalculateMonthlyFee();

    // Віртуальний метод 2: текстове подання
    public virtual string GetDescription() =>
        $"Абонемент «{MemberName}»: {CalculateMonthlyFee():F2} грн/міс";

    // Віртуальний метод з реалізацією за замовчуванням
    // (перевизначається не в усіх похідних класах)
    public virtual int GetFreezeDaysPerYear() => 14;
}
