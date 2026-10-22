using System;

internal class Employee34
{
    private string _name;
    private Department34 _dept;

    public Employee34(string name, Department34 dept)
    {
        Name = name;
        Dept = dept;
        dept.AddEmployee(this);
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

    public Department34 Dept
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
