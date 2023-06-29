// Exercise 2 <<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
Console.WriteLine("Exercise 2");

int[,] arraynumbers = new int[4, 3] { { 123, 345 ,567}, { 12, 56 ,-12}, { 34, -98,65 }, { 765, 543,321 } };
Console.WriteLine(arraynumbers[1,1]);
Console.WriteLine(arraynumbers[2,1]);

// Exercise 3 <<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
Console.WriteLine("Exercise 3");

List<string> names = new List<string>() {"Iulia","Maria","Iulius","Dan","Ilinca"};
Console.WriteLine("Introduceti un nume:");
string nume=Console.ReadLine();
if (names.Contains(nume))
{
    string element = names.ElementAt(names.IndexOf(nume));
    Console.WriteLine("Numele  " +nume+ "este in lista");
}
else
{
    names.Insert(5,nume);
    Console.WriteLine("Noul Element este " + names[5]);
}

// Exercise 4 <<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
Console.WriteLine("Exercise 4");

Stack <int> numbers = new Stack<int>();
Console.WriteLine("Introduceti primul numar!");
int num1 = Convert.ToInt32(Console.ReadLine());
numbers.Push(num1);
Console.WriteLine("Introduceti al doilea numar!");
int num2 = Convert.ToInt32(Console.ReadLine());
numbers.Push(num2);
if((num1==30)||(num2==30)||(num1+num2==30))
{
    Console.WriteLine("True");
}
else    
{
    Console.WriteLine("False");
}

// Exercise 5 <<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
Console.WriteLine("Exercise 5");

Queue <int> numq = new Queue <int> ();
Console.WriteLine("Introduceti nr1!");
int nr1 = Convert.ToInt32(Console.ReadLine());
numq.Enqueue (nr1);
Console.WriteLine("Introduceti nr2!");
int nr2 = Convert.ToInt32(Console.ReadLine());
numq.Enqueue (nr2);
Console.WriteLine("Introduceti nr3!");
int nr3 = Convert.ToInt32(Console.ReadLine());
numq.Enqueue (nr3);
Console.WriteLine("Introduceti nr4!");
int nr4 = Convert.ToInt32(Console.ReadLine());
numq.Enqueue (nr4);
Console.WriteLine("Introduceti nr5!");
int nr5 = Convert.ToInt32(Console.ReadLine());
numq.Enqueue (nr5);
int top =numq.Peek ();
if ((top > 0) & ((top % 3 == 0) || (top % 7 == 0)))
{
    Console.WriteLine("The top of the queue is " + top);
}
else
{
    numq.Dequeue ();
    Console.WriteLine("The conditions are not met.The new top is"+numq.Peek ());
}
