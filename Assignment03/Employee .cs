public enum SecurityLevel
{
    Guest,
    Developer,
    Secretary,
    DBA,
    SecurityOfficer
}

public class Employee
{
    public int ID { get; private set; }
    public string Name { get; private set; }
    public SecurityLevel SecurityPrivilege { get; private set; }
    private decimal salary;
    public decimal Salary
    {
        get => salary;
        private set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative.");
            salary = value;
        }
    }
    public HireDate HireDate { get; private set; }
    private char gender;
    public char Gender
    {
        get => gender;
        private set
        {
            if (value != 'M' && value != 'F')
                throw new ArgumentException("Gender must be 'M' or 'F'.");
            gender = value;
        }
    }

    public Employee(int id, string name, SecurityLevel securityPrivilege, decimal salary, HireDate hireDate, char gender)
    {
        ID = id;
        Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null.");
        SecurityPrivilege = securityPrivilege;
        Salary = salary;
        HireDate = hireDate ?? throw new ArgumentNullException(nameof(hireDate), "HireDate cannot be null.");
        Gender = gender;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security Level: {SecurityPrivilege}, Salary: {Salary.ToString("C")}, Hire Date: {HireDate}";
    }
}
