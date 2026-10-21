using System;

internal class Name13
{
    string? surname;
    string? firstName;
    string? patronymic;

    public string? Surname
    {
        get { return surname; }
        set { surname = value; }
    }

    public string? FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string? Patronymic
    {
        get { return patronymic; }
        set { patronymic = value; }
    }

    public Name13(string? surname = null,
        string? firstName = null,
        string? patronymic = null)
    {
        this.surname = surname;
        this.firstName = firstName;
        this.patronymic = patronymic;
    }

    public override string ToString()
    {
        string result = "";

        if (!string.IsNullOrWhiteSpace(surname))
            result += surname + " ";
        if (!string.IsNullOrWhiteSpace(firstName))
            result += firstName + " ";
        if (!string.IsNullOrWhiteSpace(patronymic))
            result += patronymic;

        return result.Trim();
    }
}