internal class Program
{
    private static void Main(string[] args)
    {
        Bank<int> bankInt = new Bank<int>();
        bankInt.InputInfo();
        Console.WriteLine(bankInt.GetInfo());

        Bank<string> bankString = new Bank<string>();
        bankString.InputInfo();
        Console.WriteLine(bankString.GetInfo());

    }
}
class Bank<T>
{
    private T AccountNumber;
    public T accountNumber
    {
        get { return AccountNumber; }
        set
        {
            if (value != null)
            {
                AccountNumber = value;
            }

        }
    }

    private double Balance;
    public double balance
    {
        get { return Balance; }
        set
        {
            if (value > 0)
            {
                Balance = value;


            }


        }
    }
    private string FIO;
    public string fio
    {
        get { return FIO; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                FIO = value;
            }
            else
            {
                Console.WriteLine("ФИО не может быть пустым, введите повторно");

            }




        }
    }
    public void InputInfo()
    {
        
        while (true)
        {
            Console.WriteLine("Введите номер счета");
            try
            {
                accountNumber = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                break;
            }

            catch
            {
                Console.WriteLine("Ошибка.Некорректный ввод счета");
            }
        }

        Console.WriteLine("Введите баланс");
        try
        {
            balance = Convert.ToDouble(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Ошибка, по умолчанию баланс 0");
            balance = 0;

        }

        Console.WriteLine("Введите ФИО");
        while (true)
        {

            FIO = Console.ReadLine();
            if (!string.IsNullOrEmpty(fio))
            {
                break;
            }
            else
            {
                Console.WriteLine("ФИО не может быть пустым, введите повторно");
            }


        }



    }
    public string GetInfo()
    {
        return $"Гражданин {FIO} имеет баланс {Balance} на счете {AccountNumber}";
    }

}