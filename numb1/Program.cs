int random_chislo = new Random().Next(10,100);
Console.Write("Случайное число: ");
Console.WriteLine(random_chislo);
int a = random_chislo/ 10;
int max = a;
int b = random_chislo% 10;
if ( b > a)
{
max = b;
}
Console.Write("Большая цифра: ");
Console.WriteLine(max);