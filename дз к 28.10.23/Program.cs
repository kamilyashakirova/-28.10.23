using System;
using System.Collections.Generic;
using System.IO;

enum AType
{
    tecuschyi,
    sberegatelnyi
}
class Program
{
    public static string Reverse(string stroka)
    {
        char[] ch = stroka.ToCharArray();
        Array.Reverse(ch);
        return new string(ch);
    }
    static void Main(string[] args)
    {
        //Упражнение 8.1. В класс банковский счет добавить метод, который переводит деньги с одного счета на другой.
        Console.WriteLine("Упражнение 8.1. В класс банковский счет добавить метод, который переводит деньги с одного счета на другой.");
        account account1 = new account(12344, AType.tecuschyi);
        account account2 = new account(343567, AType.sberegatelnyi);
        account1.PrintInfo();
        Console.WriteLine();
        account1.givememoney(609);
        account1.takemymoney(278);
        account1.PrintInfo();
        Console.WriteLine();
        account1.Transfer(account2, 451);
        account1.PrintInfo();
        account2.PrintInfo();
        //Упражнение 8.2. Реализовать метод, который в качестве входного параметра принимает строку string, возвращает строку типа string, буквы в которой идут в обратном порядке.ротестировать метод.
        Console.WriteLine("Упражнение 8.2 Реализовать метод, который принимает строку string, возвращает строку, буквы в которой идут в обратном порядке.\nЕгипетская сила");
        string stroka = "Египетская сила";
        string reversed = Reverse(stroka);
        Console.WriteLine(reversed);
        //Упражнение 8.3. Написать программу, которая спрашивает у пользователя имя файла. Если файл существует, то в выходной файл записывается содержимое исходного файла, но заглавными буквами.
        Console.WriteLine("Упражнение 8.3. Написать программу, которая спрашивает у пользователя имя файла. Если файл существует, то в выходной файл записывается содержимое исходного файла, но заглавными буквами.\nВведите полный путь файла и нажмите enter: ");
        string fileName = Console.ReadLine();
        if (!File.Exists(fileName))
        {
            Console.WriteLine("Файл не существует.");
            return;
        }
        string content = File.ReadAllText(fileName);
        string uppercaseContent = content.ToUpper();
        string outputFileName = "C:\\Users\\user\\source\\repos\\дз к 28.10.23\\дз к 28.10.23\\1дзинфабез (1).txt";
        File.WriteAllText(outputFileName, uppercaseContent);
        Console.WriteLine("изменённое содержимое файла записано в файл {0}", outputFileName);
        //Упражнение 8.4 Реализовать метод, который проверяет реализует ли входной параметр метода интерфейс System.IFormattable.
        Console.WriteLine("Упражнение 8.4 Реализовать метод, который проверяет реализует ли входной параметр метода интерфейс System.IFormattable.");
        Checker check = new Checker();
        string st = "Sweety";
        Console.WriteLine("{0}\n{1}", st, check.Check(st));
        int num = 18;
        Console.WriteLine("{0}\n{1}", num, check.Check(st));
        DateTime d = DateTime.Now;
        Console.WriteLine("{0}\n{1}", d, check.Check(d));
        Console.WriteLine(check.Check(st));
        Console.WriteLine(check.Check(num));
        Console.WriteLine(check.Check(d));
        //Домашнее задание 8.1. Сформировать новый файл, содержащий список адресов электронной почты.
        void Mailru(ref string s)
        {
            int index = s.IndexOf('#');
            if (index != -1)
            {
                s = s.Substring(index + 1).Trim();
            }
        }
        string input = @"C:\\Users\\user\\source\\repos\\дз к 28.10.23\\дз к 28.10.23\\dz8.1..txt";
        string output = @"C:\\Users\\user\\source\\repos\\дз к 28.10.23\\дз к 28.10.23\\dz8.11..txt";
        string[] lines = File.ReadAllLines(input);
        List<string> emailList = new List<string>();
        foreach (string line in lines)
        {
            string email = line;
            Mailru(ref email);
            emailList.Add(email);
        }
        File.WriteAllLines(output, emailList);
        //Домашнее задание 8.2 Список песен.
        Console.WriteLine("Домашнее задание 8.2 Список песен.");
        List<Song> songs = new List<Song>();
        Song song1 = new Song();
        song1.Name("Пачка сигарет");
        song1.Author("КИНО");
        songs.Add(song1);
        Song song2 = new Song();
        song2.Name("Without me");
        song2.Author("Eminem");
        songs.Add(song2);
        Song song3 = new Song();
        song3.Name("Young, Wild & Free");
        song3.Author("Snoop Dogg, Wiz Khalifa, Bruno Mars");
        songs.Add(song3);
        Song song4 = new Song();
        song4.Name("NO FUN");
        song4.Author("Joji");
        songs.Add(song4);
        foreach (Song song in songs)
        {
            song.print();
        }
        Console.WriteLine("Comparison: " + song1.Equals(song2));
    }
}


