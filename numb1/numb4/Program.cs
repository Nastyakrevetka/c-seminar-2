
 Console.WriteLine("Введите первое число: ");
 int chislo1 = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите второе число: ");
 int chislo2 = int.Parse(Console.ReadLine());
if (chislo2 % chislo1 == 0) 
{
Console.Write(chislo2);
Console.Write(" кратно ");
Console.Write(chislo1);
}
else {
    Console.Write("остаток ");
    Console.WriteLine(chislo2 % chislo1);
}