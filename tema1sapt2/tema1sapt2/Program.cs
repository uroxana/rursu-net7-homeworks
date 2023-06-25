//Exercise 1<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

Console.Write("Introduceti primul numar" + "  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Introduceti al doilea numar" + "  ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Introduceti al treilea numar" + "  ");
int num3 = Convert.ToInt32(Console.ReadLine());
if ((num1 == num2) & (num2 == num3) & (num1 == num3))
{
    Console.WriteLine("Cele 3 numere sunt egale");
}
else if (num1 == num2)
{
    Console.WriteLine("Numarul 1 si numarul 2 sunt egale");
}
else if (num2 == num3)
{
    Console.WriteLine("Numarul 2 si numarul 3 sunt egale");
}
else if (num1 == num3)
{
    Console.WriteLine("Numarul 1 si numarul 3 sunt egale");
}
if ((num1 > num3) & (num1 > num2))
{
    Console.WriteLine("Maximum number is " + "  " + num1);
}

else if (num2 > num3)
{
    Console.WriteLine("Maximum number is" + "  " + num2);
}
else
{
    Console.WriteLine("Maximum number is" + "  " + num3);
}
Console.WriteLine("       ");

if ((num1 < num3) & (num1 < num2))
{
    Console.WriteLine("Minimum number is " + "  " + num1);
}


else if (num2 < num3)
{
    Console.WriteLine("Minimum number is" + "  " + num2);
}
else
{
    Console.WriteLine("Minimum numer is" + "  " + num3);
}

//Exercise 2<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>

int max = num1;
max = (num1 > num2) ? ((num1 > num3) ? num1 : num3) : ((num2 > num3) ? num2 : num3);
Console.WriteLine("biggest number among " + num1 + ", " +
                   num2 + " and " + num3 + " is: " + max);
int min = num1;
min = (num1 < num2) ? ((num1 < num3) ? num1 : num3) : ((num2 < num3) ? num2 : num3);
Console.WriteLine("Smallest number among " + num1 + ", " +
                   num2 + " and " + num3 + " is: " + min);

//Exercise 3<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>
Console.WriteLine("Introduceti numarul de zile lucratoare pana la urmatoarea marire de salariu ");
int days = Convert.ToInt32(Console.ReadLine());
int years = days / 365;
days = days - (years * 365);
int months = days / 30;
days = days - (months * 30);
if (years == 1)

{
    Console.Write(years + "year");
}
else
{
    Console.Write(years + "years");
}
if (months == 1)
{
    Console.Write(months + "month");
}
else
{
    Console.Write(months + "months");
}
if (days == 1)
{
    Console.Write(days + "day");
}
else
{
    Console.WriteLine(days + "days");
}

//Exercise 4 <<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

Console.WriteLine("Enter the Physics mark!");
int Physics = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Chemistry mark!");
int Chemistry = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Biology mark!");
int Biology = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Mathematics mark!");
int Mathematics = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Computer Science mark!");
int ComputerScience = Convert.ToInt32(Console.ReadLine());
int percentage = ((Physics + Chemistry + Biology + Mathematics + ComputerScience) / 5);
if (percentage >= 90)
{
    Console.WriteLine("Percentage = " + percentage + "and grade is A");
}
else if (percentage >= 80)
{
    Console.WriteLine("Percentage = " + percentage + "and grade is B");
}
else if (percentage >= 70)
{
    Console.WriteLine("Percentage = " + percentage + "and grade is C");
}
else if (percentage >= 60)
{
    Console.WriteLine("Percentage = " + percentage + "and grade is D");
}
else if (percentage >= 40)
{
    Console.WriteLine("Percentage = " + percentage + "and grade is E");
}
else
    Console.WriteLine("Percentage = " + percentage + "and grade is F");

//Exercise 5 <<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>

Console.WriteLine("Introduce one of this grade: E, V, G, A, F ");
char input = Convert.ToChar(Console.ReadLine());

switch (input)
{
    case 'E':
        {
            Console.WriteLine("Excellent");
            break;
        }
    case 'V':
        {
            Console.WriteLine("Very Good");
            break;
        }
    case 'G':
        {
            Console.WriteLine("Good");
            break;
        }
    case 'A':
        {
            Console.WriteLine("Average");
            break;
        }
    case 'F':
        {
            Console.WriteLine("Fail");
            break;
        }
    default:
        {
            Console.WriteLine("Default");
            break;
        }
}

//Exercise 6<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


Console.WriteLine("Please enter a temperature in centigrade");
int temp = Convert.ToInt32(Console.ReadLine());
switch (temp)
{
    case int n when (n < 0):
        {
            Console.WriteLine("Freezing weather");
            break;
        }
    case int n when (0 < n && n <= 10):
        {
            Console.WriteLine("Very cold weather");
            break;
        }
    case int n when (10 < n && n <= 20):
        {
            Console.WriteLine("Cold Weather");
            break;
        }
    case int n when (20 < n && n <= 30):
        {
            Console.WriteLine("Normal in Temp");
            break;
        }
    case int n when (30 < n && n <= 40):
        {
            Console.WriteLine("It is Hot");
            break;
        }
    case int n when (n >= 40):
        {
            Console.WriteLine("It is very hot");
            break;
        }
    default:
        {
            Console.WriteLine("Default");
            break;
        }
}