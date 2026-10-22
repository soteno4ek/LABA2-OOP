using System;

internal class Department24
{
    private string _name;
    private Employee24? _boss;

    public Department24(string name)
    {
        Name = name;
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

    public Employee24? Boss
    {
        get { return _boss; }
        set { _boss = value; }
    }

    public override string ToString()
    {
        return Name;
    }
}
