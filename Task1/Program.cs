#region Task1.1
int num;
Console.WriteLine("Ədədi daxil et:");
num=Convert.ToInt32(Console.ReadLine());
if (num % 2 != 1)
{
    Console.WriteLine("Ədəd cütdür");
}
else
{
    Console.WriteLine("Ədəd təkdir");
}
#endregion
#region Task1.2
double grade;
Console.WriteLine("Balı daxil et:");
grade = Convert.ToDouble(Console.ReadLine());
if (grade >= 91 && grade <= 100)
{
    Console.WriteLine("A");
}
else if (grade >= 81 && grade < 91)
{
    Console.WriteLine("B");
}
else if (grade >= 71 && grade < 81)
{
    Console.WriteLine("C");
}
else if (grade >= 61 && grade < 71)
{
    Console.WriteLine("D");
}
else if (grade >= 51 && grade < 61)
{
    Console.WriteLine("E");
}
else if (grade >= 0 && grade < 51)
{
    Console.WriteLine("F");
}
else
{
    Console.WriteLine("Düzgün bal daxil et!!!");
}
#endregion
