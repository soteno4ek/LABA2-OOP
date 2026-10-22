using System;

internal class Name13
{
    private string? _surname;
    private string? _firstName;
    private string? _patronymic;

    public Name13(
        string? surname = null,
        string? firstName = null,
        string? patronymic = null)
    {
        Surname = surname;
        FirstName = firstName;
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
        if (!string.IsNullOrWhiteSpace(_surname))
            result += _surname + " ";
        if (!string.IsNullOrWhiteSpace(_firstName))
            result += _firstName + " ";
        if (!string.IsNullOrWhiteSpace(_patronymic))
            result += _patronymic;
        return result.Trim();
    }
}
