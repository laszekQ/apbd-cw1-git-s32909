namespace ConsoleApp;

public static class InputHandler
{
    public static double AskForANumber(String msg)
    {
        Console.Write(msg);

        double input = 0.0;
        try
        {
            input = double.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.Write("Please enter the number in a valid format: ");
            return AskForANumber("");
        }
        return input;
    }

    public static char AskForAChar(String msg)
    {
        Console.Write(msg);

        char input = '\0';

        try
        {
            char.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.Write("Please enter a single character: ");
            return AskForAChar("");
        }

        return input;
    }
}