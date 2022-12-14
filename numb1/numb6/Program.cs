Console.WriteLine("Введите первое число: ");
 int chislo1 = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите второе число: ");
 int chislo2 = int.Parse(Console.ReadLine());
if (chislo2 == chislo1*chislo1) 
{
Console.Write($"{chislo1} {chislo2} -> да");
}
else 
{
    Console.Write($"{chislo1} {chislo2} -> нет");
}
