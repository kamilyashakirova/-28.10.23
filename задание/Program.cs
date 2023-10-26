using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Employee semyon = new Employee("Семён");
        Employee rashid = new Employee("Рашид");
        Employee ilham = new Employee("О Ильхам");
        Employee lucas = new Employee("Лукас");
        Employee orkadiy = new Employee("Оркадий");
        Employee volodya = new Employee("Володя");

        Employee ilshat = new Employee("Ильшат");
        Employee ivanych = new Employee("Иваныч");
        Employee ilya = new Employee("Илья");
        Employee vitya = new Employee("Витя");
        Employee zhenya = new Employee("Женя");

        Employee sergey = new Employee("Сергей");
        Employee lyaysan = new Employee("Ляйсан");
        Employee marat = new Employee("Марат");
        Employee dina = new Employee("Дина");
        Employee ildar = new Employee("Ильдар");
        Employee anton = new Employee("Антон");

        semyon.subordinates.Add(rashid);
        semyon.subordinates.Add(ilham);
        rashid.subordinates.Add(lucas);
        ilham.subordinates.Add(orkadiy);
        ilham.subordinates.Add(volodya);
        orkadiy.subordinates.Add(ilshat);
        orkadiy.subordinates.Add(ivanych);
        ilshat.subordinates.Add(ilya);
        ilshat.subordinates.Add(vitya);
        ilshat.subordinates.Add(zhenya);
        orkadiy.subordinates.Add(sergey);
        sergey.subordinates.Add(lyaysan);
        sergey.subordinates.Add(marat);
        sergey.subordinates.Add(dina);
        sergey.subordinates.Add(ildar);
        sergey.subordinates.Add(anton);
        List<Employee> developers = new List<Employee> { marat, dina, ildar, anton };
        List<Employee> systemEngineers = new List<Employee> { ilshat, ivanych, ilya, vitya, zhenya };
        Console.WriteLine("Доступные задачи:");
        Console.WriteLine("1. Задача разработчикам");
        Console.WriteLine("2. Задача системщикам");
        Console.WriteLine("3. Задача начальству");
        bool taskAssigned = false;
        string taskName = "название задачи";
        Employee assignTo = null;
        while (!taskAssigned)
        {
            Console.WriteLine("введите, кому нужно назначить задачу (1-3):");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    assignTo = lyaysan;
                    taskAssigned = true;
                    break;
                case 2:
                    assignTo = marat;
                    taskAssigned = true;
                    break;
                case 3:
                    assignTo = orkadiy;
                    taskAssigned = true;
                    break;
                default:
                    Console.WriteLine("введено неверно, попробуйте ещё раз");
                    break;
            }
        }
        Console.WriteLine("от {0} даётся задача \"{1}\" {2}", semyon.Name, taskName, assignTo.Name);
    }
}