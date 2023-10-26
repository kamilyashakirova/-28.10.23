using System.Collections.Generic;
class Employee
{
    public string Name { get; set; }
    public List<Employee> subordinates { get; set; }

    public Employee(string name)
    {
        Name = name;
        subordinates = new List<Employee>();
    }
}
