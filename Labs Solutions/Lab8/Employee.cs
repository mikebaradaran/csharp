namespace LabsSolutions.Lab8;

public class Employee
{
    private string Name { get; set; }
    private string JobTitle { get; set; }
    private int ID { get; set; }

    protected static int idCount;

    public Employee(string name, string jobTitle)
    {
        ID = (++Employee.idCount * 10);
        Name = name;
        JobTitle = jobTitle;
    }

    public virtual string GetDetails()
    {
        return $"*****\nName: {Name}\nJob Title: {JobTitle}\nEmployee ID: {ID}\n";
    }
}
