using System;

internal class Human
{
    private string _name;
    private int _height;

    public Human(string name, int height)
    {
        Name = name;
        Height = height;
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _name = value;
            else
                throw new ArgumentException("Имя пустое");
        }
    }

    public int Height
    {
        get { return _height; }
        set
        {
            if (value > 0)
                _height = value;
            else
                throw new ArgumentException("Рост > 0");
        }
    }

    public override string ToString()
    {
        return Name + ", рост: " + Height;
    }
}
