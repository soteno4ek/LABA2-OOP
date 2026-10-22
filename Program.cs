using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Validator v = new Validator();

        Console.WriteLine("ЛАБОРАТОРНАЯ РАБОТА №2");
        Console.WriteLine();
        Console.WriteLine("--- Задание 1 ---");
        Console.WriteLine("1. №1.3 Имена.");
        Console.WriteLine("2. №1.2 Человек.");
        Console.WriteLine();
        Console.WriteLine("--- Задание 2 ---");
        Console.WriteLine("3. №2.4 Сотрудники и отделы.");
        Console.WriteLine();
        Console.WriteLine("--- Задание 3 ---");
        Console.WriteLine("4. №3.4 Сотрудники и отделы.");
        Console.WriteLine();
        Console.WriteLine("--- Задание 4 ---");
        Console.WriteLine("5. №4.5 Создаем имена.");
        Console.WriteLine();
        Console.WriteLine("--- Задание 5 ---");
        Console.WriteLine("6. №5.1 Пистолет стреляет.");

        bool running = true;
        int choice = 0;

        do
        {
            Console.WriteLine();
            choice = v.ReadInt("Введите номер: ");

            switch (choice)
            {
                case 1:
                    {
                        int mode1 = v.ReadInt(
                            "1. Вручную; 2. Авто: ");
                        Console.WriteLine();

                        if (mode1 == 1)
                        {
                            string? surname = v.ReadNullableName(
                                "Фамилия: ");
                            string? firstName = v.ReadNullableName(
                                "Имя: ");
                            string? patronymic = v.ReadNullableName(
                                "Отчество: ");
                            Console.WriteLine();

                            try
                            {
                                Name13 userName = new Name13(
                                    surname, firstName, patronymic);
                                Console.WriteLine(userName);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(
                                    "Ошибка: " + ex.Message);
                            }
                        }
                        else if (mode1 == 2)
                        {
                            try
                            {
                                Name13 n1 = new Name13("Клеопатра");
                                Name13 n2 = new Name13("Пушкин",
                                    "Александр", "Сергеевич");
                                Name13 n3 = new Name13("Маяковский",
                                    "Владимир");
                                Console.WriteLine(n1);
                                Console.WriteLine(n2);
                                Console.WriteLine(n3);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(
                                    "Ошибка: " + ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод");
                        }
                        break;
                    }

                case 2:
                    {
                        int mode2 = v.ReadInt(
                            "1. Вручную; 2. Авто: ");
                        Console.WriteLine();

                        if (mode2 == 1)
                        {
                            string hName = v.ReadName("Имя: ");
                            int hHeight = v.ReadInt("Рост: ");
                            Console.WriteLine();

                            try
                            {
                                Human userHuman = new Human(
                                    hName, hHeight);
                                Console.WriteLine(userHuman);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(
                                    "Ошибка: " + ex.Message);
                            }
                        }
                        else if (mode2 == 2)
                        {
                            try
                            {
                                Human h1 = new Human("Клеопатра", 152);
                                Human h2 = new Human("Пушкин", 167);
                                Human h3 = new Human("Владимир", 189);
                                Console.WriteLine(h1);
                                Console.WriteLine(h2);
                                Console.WriteLine(h3);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(
                                    "Ошибка: " + ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод");
                        }
                        break;
                    }

                case 3:
                    {
                        int mode3 = v.ReadInt(
                            "1. Вручную; 2. Авто: ");
                        Console.WriteLine();

                        if (mode3 == 1)
                        {
                            string dName = v.ReadName("Отдел: ");
                            int count = 0;
                            int i3 = 0;
                            string eName = "";
                            string bName = "";
                            Employee24? boss = null;
                            Department24 dept = null;
                            List<Employee24> emps = null;

                            try
                            {
                                dept = new Department24(dName);
                                count = v.ReadNonNegativeInt(
                                    "Кол-во сотрудников: ");
                                emps = new List<Employee24>();

                                for (i3 = 0; i3 < count; i3++)
                                {
                                    eName = v.ReadName("Имя: ");
                                    Employee24 emp =
                                        new Employee24(eName, dept);
                                    emps.Add(emp);
                                }

                                while (boss == null)
                                {
                                    bName = v.ReadName(
                                        "Имя начальника: ");
                                    foreach (Employee24 e in emps)
                                    {
                                        if (e.Name == bName)
                                        {
                                            boss = e;
                                            break;
                                        }
                                    }
                                    if (boss == null)
                                    {
                                        Console.WriteLine(
                                            "Такого сотрудника нет!");
                                    }
                                }
                                dept.Boss = boss;
                                Console.WriteLine();
                                foreach (Employee24 e in emps)
                                {
                                    Console.WriteLine(e);
                                }
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(
                                    "Ошибка: " + ex.Message);
                            }
                        }
                        else if (mode3 == 2)
                        {
                            try
                            {
                                Department24 it =
                                    new Department24("IT");
                                Employee24 p =
                                    new Employee24("Петров", it);
                                Employee24 k =
                                    new Employee24("Козлов", it);
                                Employee24 s =
                                    new Employee24("Сидоров", it);
                                it.Boss = k;
                                Console.WriteLine(p);
                                Console.WriteLine(k);
                                Console.WriteLine(s);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(
                                    "Ошибка: " + ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод");
                        }
                        break;
                    }

                case 4:
                    {
                        int mode4 = v.ReadInt(
                            "1. Вручную; 2. Авто: ");
                        Console.WriteLine();

                        if (mode4 == 1)
                        {
                            string dName = v.ReadName("Отдел: ");
                            int count = 0;
                            int i4 = 0;
                            string eName = "";
                            string bName = "";
                            Employee34? boss = null;
                            Department34 dept = null;
                            Employee34 firstEmp = null;

                            try
                            {
                                dept = new Department34(dName);
                                count = v.ReadNonNegativeInt(
                                    "Кол-во сотрудников: ");

                                for (i4 = 0; i4 < count; i4++)
                                {
                                    eName = v.ReadName("Имя: ");
                                    new Employee34(eName, dept);
                                }

                                while (boss == null)
                                {
                                    bName = v.ReadName(
                                        "Имя начальника: ");
                                    foreach (Employee34 e in
                                        dept.Employees)
                                    {
                                        if (e.Name == bName)
                                        {
                                            boss = e;
                                            break;
                                        }
                                    }
                                    if (boss == null)
                                    {
                                        Console.WriteLine(
                                            "Такого сотрудника нет!");
                                    }
                                }
                                dept.Boss = boss;
                                firstEmp = dept.Employees[0];

                                Console.WriteLine();
                                Console.WriteLine(
                                    "Отдел: " + firstEmp.Dept.Name);
                                Console.WriteLine(
                                    "Начальник: " +
                                    firstEmp.Dept.Boss.Name);
                                Console.WriteLine();
                                Console.WriteLine("Все сотрудники:");

                                foreach (Employee34 e in
                                    firstEmp.Dept.Employees)
                                {
                                    Console.WriteLine(e.Name);
                                }
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(
                                    "Ошибка: " + ex.Message);
                            }
                        }
                        else if (mode4 == 2)
                        {
                            try
                            {
                                Department34 it =
                                    new Department34("IT");
                                Employee34 p =
                                    new Employee34("Петров", it);
                                Employee34 k =
                                    new Employee34("Козлов", it);
                                Employee34 s =
                                    new Employee34("Сидоров", it);
                                it.Boss = k;
                                Console.WriteLine(
                                    "Отдел: " + p.Dept.Name);
                                foreach (Employee34 e in
                                    p.Dept.Employees)
                                {
                                    Console.WriteLine(e.Name);
                                }
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(
                                    "Ошибка: " + ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод");
                        }
                        break;
                    }

                case 5:
                    {
                        int mode5 = v.ReadInt(
                            "1. Вручную; 2. Авто: ");
                        Console.WriteLine();

                        if (mode5 == 1)
                        {
                            string? firstName = v.ReadNullableName(
                                "Имя: ");
                            string? surname = v.ReadNullableName(
                                "Фамилия: ");
                            string? patronymic = v.ReadNullableName(
                                "Отчество: ");
                            Console.WriteLine();

                            try
                            {
                                if (firstName != null)
                                {
                                    if (surname != null &&
                                        patronymic != null)
                                    {
                                        Console.WriteLine(
                                            new Name45(firstName,
                                                surname, patronymic));
                                    }
                                    else if (surname != null)
                                    {
                                        Console.WriteLine(
                                            new Name45(firstName,
                                                surname));
                                    }
                                    else if (patronymic != null)
                                    {
                                        Console.WriteLine(
                                            new Name45(firstName,
                                                null, patronymic));
                                    }
                                    else
                                    {
                                        Console.WriteLine(
                                            new Name45(firstName));
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(
                                        "Имя обязательно");
                                }
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(
                                    "Ошибка: " + ex.Message);
                            }
                        }
                        else if (mode5 == 2)
                        {
                            try
                            {
                                Name45 n1 = new Name45("Клеопатра");
                                Name45 n2 = new Name45("Александр",
                                    "Пушкин", "Сергеевич");
                                Name45 n3 = new Name45("Владимир",
                                    "Маяковский");
                                Name45 n4 = new Name45("Христофор",
                                    "Бонифатьевич");
                                Console.WriteLine(n1);
                                Console.WriteLine(n2);
                                Console.WriteLine(n3);
                                Console.WriteLine(n4);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(
                                    "Ошибка: " + ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод");
                        }
                        break;
                    }

                case 6:
                    {
                        int mode6 = v.ReadInt(
                            "1. Вручную; 2. Авто: ");
                        Console.WriteLine();

                        if (mode6 == 1)
                        {
                            int? ammo = v.ReadNullableInt(
                                "Кол-во патронов: ");
                            int shots = 0;
                            int i6 = 0;
                            Gun myGun = null;

                            try
                            {
                                if (ammo == null)
                                {
                                    myGun = new Gun();
                                }
                                else
                                {
                                    myGun = new Gun(ammo.Value);
                                }

                                shots = v.ReadNonNegativeInt(
                                    "Сколько выстрелов: ");
                                Console.WriteLine();

                                for (i6 = 0; i6 < shots; i6++)
                                {
                                    myGun.Shoot();
                                }
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(
                                    "Ошибка: " + ex.Message);
                            }
                        }
                        else if (mode6 == 2)
                        {
                            int i6 = 0;
                            try
                            {
                                Gun gun = new Gun(3);
                                for (i6 = 0; i6 < 5; i6++)
                                {
                                    gun.Shoot();
                                }
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(
                                    "Ошибка: " + ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод");
                        }
                        break;
                    }

                case 0:
                    Console.WriteLine("Выход");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Нет такой задачи");
                    break;
            }
        } while (running);
    }
}
