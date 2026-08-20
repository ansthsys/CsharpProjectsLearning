/// <summary>
/// Expression Body Definition <br />
/// If a constructor can be implemented as a single statement, <br />
/// you can use an <b>expression body definition</b> to assign a parameter <br />
/// to a class member when the constructor is implemented.
/// </summary>
public class Car
{
    public string modelName;

    public Car(string model) => modelName = model;

}

/// <summary>
/// Expression Body Definition <br />
/// If a constructor can be implemented as a single statement, <br />
/// you can use an <b>expression body definition</b> to assign a parameter <br />
/// to a class member when the constructor is implemented.
/// </summary>
public class Employee
{
    public int Salary;

    public Employee() { }

    public Employee(int annualSalary) => Salary = annualSalary;

    public Employee(int weeklySalary, int numberOfWeeks) => Salary = weeklySalary * numberOfWeeks;
}