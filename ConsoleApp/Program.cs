using ConsoleApp;

int n = Convert.ToInt32(InputHandler.AskForANumber("Enter the number of values: "));
double[] arr = new double[n];

Console.WriteLine("Enter the values: ");

for (int i = 0; i < n; i++)
{
    arr[i] = InputHandler.AskForANumber("");
}