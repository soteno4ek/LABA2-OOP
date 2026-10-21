using System;

internal class Name45
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

    public Name45(string firstName)
    {
        this.firstName = firstName;
    }

    public Name45(string firstName, string surname)
    {
        this.firstName = firstName;
        this.surname = surname;
    }

    public Name45(string firstName, string surname,
        string patronymic)
    {
        this.firstName = firstName;
        this.surname = surname;
        this.patronymic = patronymic;
    }

    public override string ToString()
    {
        string result = "";

        if (!string.IsNullOrWhiteSpace(firstName))
            result += firstName + " ";
        if (!string.IsNullOrWhiteSpace(patronymic))
            result += patronymic + " ";
        if (!string.IsNullOrWhiteSpace(surname))
            result += surname;

        return result.Trim();
    }
}