namespace ConsoleApp;

public static class InputHandler
{
    public static double AskForANumber(String msg)
    {
        Console.Write(msg);
        return double.Parse(Console.ReadLine());
    }
}