// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*

int TwoNumber(int number)
{
    int des = number / 10;
    int des2 = des % 10;

    number = des2;
    return number;
}

Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = TwoNumber(num);

Console.WriteLine($"New version of a number {num} is {result}");
*/


 // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
 Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2){
  Console.WriteLine("третья цифра -> " + numberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
*/

Console.WriteLine("Version 2");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberAdd = Convert.ToString(number);
if (numberAdd.Length > 2)
{
  Console.WriteLine($"Третья цифра = {numberAdd[3]}");
}
else
{
Console.WriteLine("Третьей цифры нет.");
}
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(Это выходной день) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Это не день недели");
  }
  else Console.WriteLine("(Этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);
*/