using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Collections.Immutable;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Numerics;
//<<<<<<<<Exercise 1>>>>>>>>>
Console.WriteLine("Exercise 1");
int[]arraynumbers = new int[5] {1,2,3,4,5};
List<int> even = new List<int>();
int sum = 0;
for (int a = 1; a<=arraynumbers.Length; a++)
{
    if (a % 2 == 0)
    {
        even.Add(a);
    }
}
Console.WriteLine("The even numbers in the array are");
foreach (int b in even)
{
    Console.Write(b+" ");
}
Console.WriteLine();
sum=+even.Sum();
Console.WriteLine("the total of all the values that are even numbers  "+sum);

//<<<<<<<<Exercise 2>>>>>>>>>
Console.WriteLine("Exercise 2");
int[] array1 = new int[5] {1,2,3,3,4};
Console.WriteLine("Duplicate elements in given array: ");
for (int e = 0; e< array1.Length; e++)
{
    for (int f = e + 1; f < array1.Length; f++)
    {
        if (array1[e] == array1[f])
        {
            Console.WriteLine(array1[f] + " ");
        }
    }
} 

//<<<<<<<<Exercise 3>>>>>>>>>
Console.WriteLine("Exercise 3");
List<string> list1 = new List<string>() {"a","b","b","c","c","d"};
string[] array1n = list1.ToArray();
List<string> duplicat = new List<string>();
for (int g = 0; g < array1n.Length; g++)
{
    for (int h = g + 1; h < array1n.Length; h++)
    {
        if (array1n[g] == array1n[h])
        {
            duplicat.Add( array1n[g]);
            list1.Remove(array1n[g]);
        }
    }
}
Console.WriteLine("Lista fara duplicat");
for (int i = 0; i< list1.Count; i++)
{
    {
        Console.WriteLine(""+list1[i]);
    }
}
Console.WriteLine();
Console.WriteLine(" Lista elemente gasite duplicat");
for (int j = 0; j < duplicat.Count; j++)
{
    {
        Console.WriteLine(""+duplicat[j]);
    }
}

//<<<<<<<<Exercise 4>>>>>>>>>
Console.WriteLine("Exercise 4");
int[] arr1 = new int[9] {1,4,5,2,1,4,3,1,2};
int[] fr = new int[arr1.Length];
int visited = -1;
for (int k = 0; k < arr1.Length; k++)
{
    int count = 1;
    for (int l = k + 1; l < arr1.Length; l++)
    {
        if (arr1[k] == arr1[l])
        {
            count++; 
            fr[l] = visited;
        }
    }
    if (fr[k] != visited)
        fr[k] = count;
}
 Console.WriteLine(" Element | Frequency");
for (int m = 0; m < fr.Length; m++)
{
    if (fr[m] != visited)
    {
        if (fr[m] > 1)
        {
            Console.WriteLine("    " + arr1[m] + "  " + fr[m] + "times");
        }
        else
        {
            Console.WriteLine("    " + arr1[m] + "  " + fr[m] + "time");
        }
    }
}
Console.WriteLine();

//<<<<<<<<Exercise 5>>>>>>>>>
Console.WriteLine("Exercise 5");
int[] array2 = new int[6];
int[] even1 = new int[6];
int[] odd = new int[6];
int  p = 0, q = 0;
Console.WriteLine("Input elements in the array ");
for (int n= 0; n < array2.Length; n++)
{
    Console.Write("element - {0} : ", n);
    array2[n] = Convert.ToInt32(Console.ReadLine());
}
for (int o = 0; o <= array2.Length; o++)
{
    if (array2[o] % 2 == 0)
    {
        even1[p] = array2[o];
        p++;
    }
    else
    {
        odd[q] = array2[o];
        q++;
    }
}
Console.Write("\nThe Even elements are : \n");
for (int r = 0; r < p; r++)
{
    Console.Write("{0} ", even1[r]);
}
Console.Write("\nThe Odd elements are :\n");
for (int s = 0; s < q; s++)
{
    Console.Write("{0} ", odd[s]);
}

//<<<<<<<<Exercise 6>>>>>>>>>
Console.WriteLine("Exercise 6");
Console.WriteLine("Enter the first number");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int number2= Convert.ToInt32(Console.ReadLine());
List<int> numbers=new List<int>();
if (number1 < number2)
{
    for (int t = number1; t <= number2; t++)
    {
        numbers.Add(t);
    }
}
else if (number1 > number2)
{
    for (int u = number1; u >= number2; u--)
    {
        numbers.Add(u);
    }
}
Console.WriteLine("The collection elements: ");
foreach (int inum in numbers)
{ Console.WriteLine(inum); }
Console.WriteLine("the collection elements that divide by 3 : ");
for(int v=0; v<=numbers.Count; v++)
{
    if (numbers[v]%3 == 0)
    { 
            Console.WriteLine(numbers[v]);
    } 
}

//<<<<<<<<Exercise 7>>>>>>>>>
Console.WriteLine("Exercise 7");
List<int> newnumber1 = new List<int>();
for (int x = 123; x <= 243; x++)
{
    newnumber1.Add(x);
}
foreach (int no in newnumber1)
{
    if ((no % 3 == 0)& (no % 5 == 0))
    {
        Console.WriteLine(no + "FizzBuzz");
    }
    else if (no % 3 == 0)
    {
        Console.WriteLine(no + "Fizz");
    }
    else if (no % 5 == 0) 
    {
        Console.WriteLine(no + "Bizz");
    }
    else 
    {
        Console.WriteLine(no);
    }
}

//<<<<<<<<Exercise 8>>>>>>>>>
Console.WriteLine("Exercise 8");
List<string> Names = new List<string>();
Console.WriteLine("enter ten names");
for (int ii = 0; ii < 10; ii++)
{
    string input = Console.ReadLine();
    Names.Add(input);
}
int rr = 0;
while (rr<= 5)
{
    Console.WriteLine(Names[rr]);
    rr++;
}

//<<<<<<<<Exercise 9>>>>>>>>>
Console.WriteLine("Exercise 9");
int inputnumber;
do
{
    inputnumber = Convert.ToInt32(Console.ReadLine());
}
while (inputnumber != 0);

//<<<<<<<<Exercise 10>>>>>>>>>
Console.WriteLine("Exercise 10");
List<int> newnum = new List<int>();
int ix = -1; ;
    do
{
    newnum.Add(ix);
    ix--;
    int div = newnum[ix] % 21;
    Console.WriteLine(div);
    if (div == 0)
            break;
}
    while (ix >= -123);
foreach (int num in newnum)
{
    Console.WriteLine(num);
}

//<<<<<<<<Exercise 11>>>>>>>>>
Console.WriteLine("Exercise 11");
List<string> NamesN = new List<string>();
Console.WriteLine("Enter ten names");
/*int i = 0;
while(i < 10); 
{
        string inputi = Console.ReadLine();
    NamesN.Add(inputi);
    i++;
}*/

for(int ia = 0; ia < 10; ia++)
{
    string inputi = Console.ReadLine();
    NamesN.Add(inputi);
}
for (int ef = 0; ef < NamesN.Count; ef++)
{
    if (NamesN[ef].StartsWith("a"))
        continue;
    if (NamesN[ef].StartsWith("A"))
        continue;
    if (NamesN[ef].StartsWith("b"))
        continue;
    if (NamesN[ef].StartsWith("B"))
        continue;
    else
    { Console.WriteLine(NamesN[ef]); }
}  

