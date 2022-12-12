/*Задача 40: Напишите программу,
 которая принимает на вход три числа 
  проверяет, может ли существовать треугольник с сторонами такой длины.*/

int  GetNumberFromConsole(string message)
{
bool isCorrect = false;
int result = 0;

while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result))
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не число. Введите число");
}
}
return result;
}
int a = GetNumberFromConsole("введите первую сторону");
int b = GetNumberFromConsole("введите вторую сторону");
int с = GetNumberFromConsole("введите третью сторону");

if ((a+b)>с && (b+с)>a && (a+с)>b)
{
Console.WriteLine("триугольник сушествует: ");
}
else
Console.WriteLine("триугольник не сушествует: ");