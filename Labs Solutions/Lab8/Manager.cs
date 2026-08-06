using System.Collections.Generic;
using System.Text;

public class Manager : Employee
{
    internal List<Employee> employees = null;

    public Manager(string name, string jobTitle) : base(name, jobTitle)
    {
        employees = new List<Employee>();
    }

    public void AddEmployee(Employee emp)
    {
        employees.Add(emp);
    }

    public override string GetDetails()
    {
        StringBuilder res = new StringBuilder(base.GetDetails());
        foreach (Employee employee in employees)
        {
            res.Append("\t"+employee.GetDetails());
        }
        return res.ToString();
    }
}
