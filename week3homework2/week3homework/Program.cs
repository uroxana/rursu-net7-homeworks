// Bubble sort
int[] numbers = { 42, 30, 28, 15, -12, 4, 16 };
int t;
Console.WriteLine("Original array :");
foreach (int number in numbers)
    Console.Write(number + " ");
for (int p = 0; p <= numbers.Length - 2; p++)
{
    for (int i = 0; i <= numbers.Length - 2; i++)
    {
        if (numbers[i] > numbers[i + 1])
        {
            t = numbers[i + 1];
            numbers[i + 1] = numbers[i];
            numbers[i] = t;
        }
    }
}
Console.WriteLine("\n" + "Sorted array :");
foreach (int number in numbers)
    Console.Write(number + " ");
Console.Write("\n");

