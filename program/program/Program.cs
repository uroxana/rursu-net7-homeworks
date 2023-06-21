// See https://aka.ms/new-console-template for more information
// Exercise 1
Console.WriteLine("Introdu primul numar");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Introdu al doilea numar");
double number2 = Convert.ToDouble(Console.ReadLine());
double Addition = number1 + number2;
double Subtraction = number1 - number2;
double Division = number1 / number2; 
double Multiplication = number1 * number2;
double Modulo = number1 % number2;
Console.WriteLine("Addition=" + Addition);
Console.WriteLine("Subtraction=" + Subtraction);
Console.WriteLine("Division=" + Division);
Console.WriteLine("Multiplication=" + Multiplication);
Console.WriteLine("Modulo=" + Modulo);
// Exercise 2
Console.WriteLine("nr1+10=  "+(number1 + 10));
Console.WriteLine("nr2-3=  "+(number2 -3));
Console.WriteLine("nr1*100=  "+(number1*100));
Console.WriteLine("nr2/100=  "+(number2/100));
Console.WriteLine("nr1%2=  "+(number1 % 2));
Console.WriteLine("Afiseaza valoarea actuala a numarului 1 si numarului 2 " + "nr1=" + (number1) + "nr2=" + (number2));
Console.WriteLine("++nr2 " + (++number2));
Console.WriteLine("--nr1=  " + (--number1));
Console.WriteLine("Afiseaza valoarea actuala a numarului 1 si numarului 2 " + "nr1=" + (number1) + "nr2=" + (number2));
Console.WriteLine("nr1+=5 " + (number1 += 5));
Console.WriteLine("nr2-=5 " + (number2 -= 5));
Console.WriteLine("Afiseaza valoarea actuala a numarului 1 si numarului 2 " + "nr1="+(number1) + "nr2="+(number2));
// Exercise 3
Console.WriteLine("Introdu un numar ");
int nr1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Introdu alt numar");
int nr2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Numarul1 este egal cu Numarul2       " + (nr1 == nr2));
Console.WriteLine();
Console.WriteLine("Numarul1 este diferit de Numarul2    " + (nr1 != nr2));
Console.WriteLine();  
Console.WriteLine("Numerele sunt mai mari ca 10         " + ((nr1>10) && (nr2 >10)));
Console.WriteLine();
Console.WriteLine("Suma numerelor este mai mare ca 10   " + ((nr1 > 10) || (nr2 > 10)));
Console.WriteLine();
Console.WriteLine("Numarul1 este mai mare ca numarul2   " +(!(nr2 >= nr1)));







