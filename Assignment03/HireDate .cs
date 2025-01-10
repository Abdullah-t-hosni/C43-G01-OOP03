public class HireDate : IComparable<HireDate>
{
    public int Day { get; private set; }
    public int Month { get; private set; }
    public int Year { get; private set; }

    public HireDate(int day, int month, int year)
    {
        if (month < 1 || month > 12)
            throw new ArgumentException("Month must be between 1 and 12.");
        if (day < 1 || day > DateTime.DaysInMonth(year, month))
            throw new ArgumentException("Invalid day for the given month and year.");

        Day = day;
        Month = month;
        Year = year;
    }

    public int CompareTo(HireDate other)
    {
        // Compare years, months, then days
        if (other == null) return 1;
        if (this.Year != other.Year)
            return this.Year.CompareTo(other.Year);
        if (this.Month != other.Month)
            return this.Month.CompareTo(other.Month);
        return this.Day.CompareTo(other.Day);
    }

    public override string ToString()
    {
        return $"{Day:D2}/{Month:D2}/{Year}";
    }
}
