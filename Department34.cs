using System;
using System.Collections.Generic;

internal class Department34
{
    string name;
    Employee34 boss;
    List<Employee34> employees;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Employee34 Boss
    {
        get { return boss; }
        set { boss = value; }
    }

    public List<Employee34> Employees
    {
        get { return employees; }
    }

    public Department34(string name)
    {
        this.name = name;
        employees = new List<Employee34>();
    }

    public void AddEmployee(Employee34 emp)
    {
        employees.Add(emp);
    }

    public override string ToString()
    {
        return Name;
    }
}