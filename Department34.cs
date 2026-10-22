using System;
using System.Collections.Generic;

internal class Department34
{
    private string _name;
    private Employee34? _boss;
    private List<Employee34> _employees;

    public Department34(string name)
    {
        Name = name;
        _employees = new List<Employee34>();
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _name = value;
            else
                throw new ArgumentException("Пустое имя");
        }
    }

    public Employee34? Boss
    {
        get { return _boss; }
        set { _boss = value; }
    }

    public List<Employee34> Employees
    {
        get { return _employees; }
    }

    public void AddEmployee(Employee34 emp)
    {
        _employees.Add(emp);
    }

    public override string ToString()
    {
        return Name;
    }
}
