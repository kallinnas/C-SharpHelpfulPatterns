namespace C_HelpfulPatterns;

internal class SolidOpenClose
{
    public void Run()
    {
        Employee fullTimeEmployee = new FullTimeEmployee();
        Employee partTimeEmployee = new PartTimeEmployee();
        Employee contractor = new Contractor();

        Console.WriteLine($"FullTimeEmployee Salary: {fullTimeEmployee.CalculateSalary()}");
        Console.WriteLine($"PartTimeEmployee Salary: {partTimeEmployee.CalculateSalary()}");
        Console.WriteLine($"Contractor Salary: {contractor.CalculateSalary()}");
    }
}

public abstract class Employee
{
    public abstract decimal CalculateSalary();
}

public class FullTimeEmployee : Employee
{
    public override decimal CalculateSalary() { return 50000m; }
}

public class PartTimeEmployee : Employee
{
    public override decimal CalculateSalary() { return 20000m; }
}

public class Contractor : Employee
{
    public override decimal CalculateSalary() { return 30000m; }
}
