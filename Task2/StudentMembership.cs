namespace Task2;

public class StudentMembership : Membership
{
    public string University { get; }
    public DateOnly StudyConfirmedUntil { get; }

    public StudentMembership(string memberName, decimal baseFee, string university, DateOnly studyConfirmedUntil)
        : base(memberName, baseFee)
    {
        University = university;
        StudyConfirmedUntil = studyConfirmedUntil;
        Trace("конструктор StudentMembership");
    }

    public override string Category => "Студент";

    // СКРІН 3: щоб отримати помилку CS0534, закоментуйте наступний рядок
    public override decimal CalculateMonthlyFee() => BaseFee * 0.6m;

    // Член, якого НЕМАЄ в контракті базового класу
    public bool IsStudyStatusValid(DateOnly onDate) => onDate <= StudyConfirmedUntil;
}
