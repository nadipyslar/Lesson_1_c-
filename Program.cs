//max из 2х чисел
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
/*
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
*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//Элементы задаются рандомно (диапазон выбрать самостоятельно) Итоговый массив должен содержать в себе суммы цифр числа. 
//Т.е. необходимо подсчитывать суммы цифр каждого числа и записывать их в новый массив.
/*
int lenArray = 8;
int [] randomArray = new int [lenArray];
for (int i=0; i<randomArray.Length; i++)
{
    randomArray[i]=new Random().Next(10,99);
    Console.Write(randomArray[i]+" ");
}
*/
//string [] NewMass = Array.ConvertAll(randomArray,i=>i.ToString());
/*int lenArray2 = 8;
int [] random2=new int [lenArray2];
for (int i=0; i<random2.Length;i++) random2[i]=(randomArray[i]/10+randomArray[i]%10);

void PrintArray(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

PrintArray(random2);  
*/
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*int lenArray = 5;
int [] randomArray = new int [lenArray];
for (int i=0; i<randomArray.Length; i++)
{
    randomArray[i]=new Random().Next(100,999);
    Console.Write(randomArray[i]+" ");
}
void Count (int [] arr){
int c = 0;
    for (int i=0; i<arr.Length; i++)
    if (arr[i]%2==0) 
    c++;
   Console.WriteLine(c+" ");
} 
Count(randomArray);
*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*int lenArray = 5;
int [] randomArray = new int [lenArray];
for (int i=0; i<randomArray.Length; i++)
{
    randomArray[i]=new Random().Next(10,999);
    Console.Write(randomArray[i]+" ");
}
void sumOfOdd (int [] arr){
int sum = 0;
    for (int i=0; i<arr.Length; i=i+2)
    sum=sum+arr[i]; 
   Console.WriteLine(sum+" ");
} 
sumOfOdd(randomArray);
*/
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*int lenArray = 5;
double [] randomArray = new double [lenArray];
for (int i=0; i<randomArray.Length; i++)
{
    randomArray[i]=new Random().Next(10,999);
    Console.Write(randomArray[i]+" ");
}
Console.WriteLine("");
void DiffMaxMin (double [] arr){
    double max = arr[0];
    double min = arr[0];
    double DiffMaxMin = 0;
    for (int i=0; i<arr.Length; i++)
        if (arr[i]>max) max = arr[i];
        else if (arr[i]<min) min =arr[i];
    DiffMaxMin = max - min;
    Console.WriteLine(DiffMaxMin);
}
DiffMaxMin(randomArray);
*/

//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*Console.Write("Введите элементы через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
        count++;
}
Console.WriteLine($"Кол-во элементов > 0: {count}");
*/
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double numberX = (b2 - b1)/(k1 - k2);
double numberY = k2 * numberX + b2;

Console.WriteLine($"Точка пересечения двух прямых: {numberX},{numberY}");
*/
 //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*Console.WriteLine("введите количество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов массива");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] RandomNumbers = new double [rows, columns];
FillArray(RandomNumbers);
PrintArray(RandomNumbers);

void FillArray(double[,] array){
    for (int i = 0; i<array.GetLength(0); i++)
        for (int j = 0; j<array.GetLength(1); j++)
            array[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
}
void PrintArray(double [,]array){
    for (int i = 0; i < array.GetLength(0); i++){
    Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
        Console.Write("]");
        Console.WriteLine("");
    }
}
*/
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
//или же указание, что такого элемента нет.

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);
if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
    Console.WriteLine("такого элемента нет");
else
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
PrintArray(numbers);
void FillArrayRandomNumbers(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
                array [i,j] = new Random().Next(-100, 100)/10;
               
        }
void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
           
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
