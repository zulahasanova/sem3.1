семинар 3.1

/* Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
на само себя). 
4 -> 16
-3 -> 9
-7 -. 49 */

Console.Write("Введите число: ");
int numberDayofWeek = int.Parse(Console.ReadLine()!);
//решение математическим путем
int sqr = numberDayofWeek * numberDayofWeek;
Console.WriteLine($"Квадрат числа {numberDayofWeek} равен {sqr}");
//решение с использованием библиотеки
int sqr1 = Convert.ToInt32(Math.Pow(numberDayofWeek, 5));  //5 это в какое число возводит в степень
//Convert.ToInt32 для double
Console.WriteLine($"Квадрат числа {numberDayofWeek} равен {sqr1}"); 

/*1.Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое число квадратом второго. 

a = 25; b = 5->да
a = 2 b = 10->нет
a = 9; b = -3->да
a = -3 b = 9->нет  */

Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine()!);


if (num1 == num2 * num2) //первое число = второе * второе
{
    Console.Write("да");
}
else
    Console.Write("нет"); 

/*3. Напишите программу, которая будет выдавать название
дня недели по заданному номеру.

3 -> Среда
5 -> Пятница */

Console.Write("Введите число: ");
int numberDayofWeek = int.Parse(Console.ReadLine()!);

while(numberDayofWeek < 1 || numberDayofWeek > 7){
    Console.Write("Введен неправильный номер");
    return;}
if (numberDayofWeek == 1){
    Console.Write("понедельник");}
else if (numberDayofWeek == 2){
    Console.Write("вторник");}
else if (numberDayofWeek == 3){
    Console.Write("среда");}
else if (numberDayofWeek == 4){
    Console.Write("четверг");}
else if (numberDayofWeek == 5){
    Console.Write("пятница");}
else if (numberDayofWeek == 6){
    Console.Write("суббота");}
else if (numberDayofWeek == 7){
    Console.Write("воскресенье");} 

/*5. Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"   */

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = -n; i < n; i++)
{
    Console.Write($" {i},"); 
} 
//можно так
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!); //ABS - модуль
int B = (-1) * Math.Abs(N);
while (B <= Math.Abs(N))
{
    Console.Write($" {B},");
    B++;
} 

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int y = number % 10;

    Console.Write($"{y}");
