namespace HelloApp;

public class Program
{
    public static void GreetBlack()
    {
        Console.WriteLine("hello black");
    }
    public static void GreetWhite()
    {
        Console.WriteLine("hello white");
    }

    public static void Main()
    {
        Console.WriteLine("hello everyone");
        GreetBlack();
        GreetWhite();
    }
}

