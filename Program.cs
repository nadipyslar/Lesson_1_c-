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


//третья цифра числа или "3ей цифры нет"
/*
Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());
string n=Convert.ToString(number1); 
if (n.Length>2) Console.WriteLine ("третья цифра "+n[2]);
else Console.WriteLine("третьей цифры нет");
*/




//проверка цифры на выходной

/*Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
void Weekend (int n)
{
    if (n ==6 | n == 7) Console.WriteLine("Это выходной");
    else Console.WriteLine("Это не выходной");
}
Weekend (n);
*/
/*
void IndexChetvert(int n){
    if (n==1) Console.WriteLine("x>0y>0");
else Console.WriteLine("www");
}
int n = int.Parse(Console.ReadLine());
IndexChetvert (n);
*/

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите пятизначное число");
string n = Console.ReadLine();
void CheckPalindrom (string n)
{if (n [4] == n [0] && n [1] == n[3]) Console.WriteLine("Это палиндром");
else Console.WriteLine("Это не палиндром"); }

CheckPalindrom (n);
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1;

double length = Math.Sqrt(x*x+y*y+z*z);
Console.WriteLine(length);
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

/*Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
void Cube (int N){
    for (int i=1; i<N;i++)
Console.WriteLine(i*i*i);
}
Cube (N);
*/

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Сделать в функции, сделать проверку на отрицательность.

/*
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = Math.Abs(b);
Console.WriteLine(Math.Pow(a,c));
*/
 
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
int a = int.Parse(Console.ReadLine());
int sum = 0;
int count = Convert.ToString(a).Length;
int tempr = 0;
for (int i=0; i<count; i++){
    tempr = a-a%10;
    sum = sum + (a - tempr);
    a = a/10;
}
Console.WriteLine(sum);

