using System;

internal class Employee34
{
    string name;
    Department34 dept;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Department34 Dept
    {
        get { return dept; }
        set { dept = value; }
    }

    public Employee34(string name, Department34 dept)
    {
        this.name = name;
        this.dept = dept;
        dept.AddEmployee(this);
    }

    public override string ToString()
    {
        if (Dept.Boss == this)
        {
            return Name + " начальник отдела " +
                Dept.Name;
        }

        string bossName = "нет";
        if (Dept.Boss != null)
        {
            bossName = Dept.Boss.Name;
        }

        return Name + " работает в отделе " +
            Dept.Name + ", начальник которого " +
            bossName;
    }
}