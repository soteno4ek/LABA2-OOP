using System;

internal class Employee24
{
    private string _name;
    private Department24 _dept;

    public Employee24(string name, Department24 dept)
    {
        Name = name;
        Dept = dept;
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

    public Department24 Dept
    {
        get { return _dept; }
        set
        {
            if (value != null)
                _dept = value;
            else
                throw new ArgumentException("Нет отдела");
        }
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
