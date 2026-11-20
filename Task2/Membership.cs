namespace Task2;

// Абстрактний клас: контракт для всіх конкретних видів абонементів
public abstract class Membership
{
    // Лише для демонстрації ланцюжка викликів конструкторів (Завдання 2, п. 4)
    public static bool TraceConstruction { get; set; }

    public string MemberName { get; }
    protected decimal BaseFee { get; }

    // Захищений конструктор: викликається похідними класами через base(...)
    protected Membership(string memberName, decimal baseFee)
    {
        MemberName = memberName;
        BaseFee = baseFee;
        Trace($"конструктор Membership: MemberName = {memberName}, BaseFee = {baseFee}");
    }

    // ---- Абстрактні члени: мінімальний контракт ----
    public abstract string Category { get; }
    public abstract decimal CalculateMonthlyFee();

    // ---- Віртуальні члени з реалізацією за замовчуванням ----
    public virtual string GetDescription() =>
        $"[{Category}] {MemberName}: {CalculateMonthlyFee():F2} грн/міс";

    public virtual int GetFreezeDaysPerYear() => 14;

    protected static void Trace(string text)
    {
        if (TraceConstruction)
            Console.WriteLine($"   [ctor] {text}");
    }
}
