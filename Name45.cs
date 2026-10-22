using System;

internal class Name45
{
    private string? _surname;
    private string? _firstName;
    private string? _patronymic;

    public Name45(string? firstName)
    {
        FirstName = firstName;
    }

    public Name45(string? firstName, string? surname)
    {
        FirstName = firstName;
        Surname = surname;
    }

    public Name45(
        string? firstName,
        string? surname,
        string? patronymic)
    {
        FirstName = firstName;
        Surname = surname;
        Patronymic = patronymic;
    }

    public string? Surname
    {
        get { return _surname; }
        set
        {
            if (value == null ||
                Validator.IsLettersOnly(value))
            {
                _surname = value;
            }
            else
            {
                throw new ArgumentException("Только буквы");
            }
        }
    }

    public string? FirstName
    {
        get { return _firstName; }
        set
        {
            if (value == null ||
                Validator.IsLettersOnly(value))
            {
                _firstName = value;
            }
            else
            {
                throw new ArgumentException("Только буквы");
            }
        }
    }

    public string? Patronymic
    {
        get { return _patronymic; }
        set
        {
            if (value == null ||
                Validator.IsLettersOnly(value))
            {
                _patronymic = value;
            }
            else
            {
                throw new ArgumentException("Только буквы");
            }
        }
    }

    public override string ToString()
    {
        string result = "";
        if (!string.IsNullOrWhiteSpace(_firstName))
            result += _firstName + " ";
        if (!string.IsNullOrWhiteSpace(_patronymic))
            result += _patronymic + " ";
        if (!string.IsNullOrWhiteSpace(_surname))
            result += _surname;
        return result.Trim();
    }
}
