﻿int random_chisl = new Random().Next(100,1000);
Console.Write("Случайное число: ");
Console.WriteLine(random_chisl);
int pervoe = random_chisl/ 100;
Console.WriteLine(pervoe);
int vtoroe = random_chisl/10;
    vtoroe = vtoroe % 10;
int tretye = random_chisl% 10;
Console.WriteLine(tretye);
int novoe = pervoe*10 + tretye;
Console.Write("Новое число: ");
Console.WriteLine(novoe);