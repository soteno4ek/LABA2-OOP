using System;

internal class Department24
{
    string name;
    Employee24 boss;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Employee24 Boss
    {
        get { return boss; }
        set { boss = value; }
    }

    public Department24(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}