﻿//max из 2х чисел
/*
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number1>number2) Console.WriteLine($"max = {number1},min= {number2}");
else Console.WriteLine($"max = {number2},min= {number1}");
*/

//max из 3х чисел
/*
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());
if (number1>number2&&number1>number3) Console.WriteLine("max ="+number1);
else if (number2>number1&&number2>number3) Console.WriteLine("max ="+number2); 
else if (number3>number1&&number3>number2) Console.WriteLine("max ="+number3); 
*/

//является ли число четным
/*
int number1 = int.Parse(Console.ReadLine());
if (number1 % 2==0) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");
*/

/*
//все четные от 1 до N
int n = int.Parse(Console.ReadLine());
int m = 2;
while (m < n){ Console.WriteLine(m);
m+=2;
*/

/*
//вторая цифра трехзначного числа
int num = new Random().Next (100,999);
Console.WriteLine(num);
Console.WriteLine($"Вторая цифра числа {num%100/10}");
*/