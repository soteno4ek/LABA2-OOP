using System;

internal class Gun
{
    private int _ammo;

    public Gun()
    {
        Ammo = 5;
    }

    public Gun(int ammo)
    {
        Ammo = ammo;
    }

    public int Ammo
    {
        get { return _ammo; }
        set
        {
            if (value >= 0)
                _ammo = value;
            else
                throw new ArgumentException("Патроны < 0");
        }
    }

    public void Shoot()
    {
        if (Ammo > 0)
        {
            Console.WriteLine("Бах!");
            Ammo = Ammo - 1;
        }
        else
        {
            Console.WriteLine("Клац!");
        }
    }

    public override string ToString()
    {
        return "Патронов: " + Ammo;
    }
}
