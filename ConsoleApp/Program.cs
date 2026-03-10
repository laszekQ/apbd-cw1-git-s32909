using ConsoleApp;

int n = Convert.ToInt32(InputHandler.AskForANumber("Enter the number of values: "));
double[] arr = new double[n];

Console.WriteLine("Enter the values: ");

for (int i = 0; i < n; i++)
{
    arr[i] = InputHandler.AskForANumber("");
}

Action:
char act = InputHandler.AskForAChar("Calculate the average(a) or the median(m)?: ");

switch (act)
{
    case 'a':
        Console.WriteLine("The average is: {0}", StatisticsHelper.CalculateAverage(arr));
        break;
    case 'm':
        Console.WriteLine("The median is: {0}", StatisticsHelper.CalculateMedian(arr));
        break;
    default:
        Console.WriteLine("Invalid input");
        goto Action;
}