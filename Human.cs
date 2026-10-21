internal class Human
{
    string name;
    int height;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Height
    {
        get { return height; }
        set { height = value; }
    }

    public Human(string name, int height)
    {
        this.name = name;
        this.height = height;
    }

    public override string ToString()
    {
        return Name + ", рост: " + Height;
    }
}