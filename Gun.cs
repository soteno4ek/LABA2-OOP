internal class Gun
{
    int ammo;

    public int Ammo
    {
        get { return ammo; }
        set { ammo = value; }
    }

    public Gun()
    {
        ammo = 5;
    }

    public Gun(int ammo)
    {
        Ammo = ammo;
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