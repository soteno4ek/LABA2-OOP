using System;

internal class Employee24
{
    string name;
    Department24 dept;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Department24 Dept
    {
        get { return dept; }
        set { dept = value; }
    }

    public Employee24(string name, Department24 dept)
    {
        this.name = name;
        this.dept = dept;
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