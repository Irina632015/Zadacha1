// See https://aka.ms/new-console-template for more information
int Num1 = Convert.ToInt32(Console.ReadLine());
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num1 > Num2)

{
    Console.WriteLine(Num1 + " > " + Num2);
}
else if (Num2 > Num1)
{
    Console.WriteLine(Num2 + " > " + Num1);
}
else
{
    Console.WriteLine(Num2 + " = " + Num1);
}
