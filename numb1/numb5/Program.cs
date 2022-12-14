Console.WriteLine("Введите число: ");
int chislo1 = int.Parse(Console.ReadLine());
if (chislo1 % 23 == 0 && chislo1 % 7 == 0)
{
 Console.Write($"{chislo1} -> да");  
}
else
{
Console.Write($"{chislo1} -> нет");
}