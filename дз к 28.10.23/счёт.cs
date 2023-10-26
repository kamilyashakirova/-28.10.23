using System;

class account
{
    private static int accountnum = 3457;

    public int number { get; private set; }
    public decimal balance { get; private set; }
    public AType type { get; private set; }

    public account(decimal initialBalance, AType accountType)
    {
        number = generate();
        balance = initialBalance;
        type = accountType;
    }

    private int generate()
    {
        return ++accountnum;
    }

    public void givememoney(decimal a)
    {
        if (a > 0)
        {
            balance += a;
        }
    }

    public bool takemymoney(decimal a)
    {
        if (a > balance)
        {
            Console.WriteLine("нет денег!");

            return false;
        }

        balance -= a;
        Console.WriteLine("перевод был успешно совершён");
        return true;
    }

    public void Transfer(account account, decimal a)
    {
        if (takemymoney(a))
        {
            Console.WriteLine("перевод был успешно совершён");
            account.givememoney(a); 
        }
        else
        {
            Console.WriteLine("не удалось осуществить перевод");
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine("номер счёта: " + accountnum);
        Console.WriteLine("баланс: " + balance);
        Console.WriteLine("тип счёта: " + type);
    }
}

