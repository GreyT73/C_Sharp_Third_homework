Console.Clear();
System.Console.WriteLine("Задача 19");
System.Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
System.Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
if (number >= 10000 & number <= 99999)
{
    int num1 = number % 10; // Узнаем последнюю цифру
    int num2 = (number / 10) % 10; // Узнаем вторую цифру с конца
    int num4 = (number / 1000) % 10; // Получаем вторую цифру с начала
    int num5 = number / 10000; // Первая по порядку цифра
    if (num1 == num5 && num2 == num4)
    {
        System.Console.WriteLine($"Число {number} - палиндром");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Неправильное значение. Требовалось пятизначное число");
}
System.Console.WriteLine("Press Enter to continue");
Console.ReadLine();
Console.Clear();

System.Console.WriteLine("Задача 21");
System.Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
System.Console.WriteLine("Введите xa: ");
double xa = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите ya: ");
double ya = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите za: ");
double za = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите xb: ");
double xb = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите yb: ");
double yb = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите zb: ");
double zb = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2)));

System.Console.WriteLine("Press Enter to continue");
Console.ReadLine();
Console.Clear();

System.Console.WriteLine("Задача 23");
System.Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N."); 
System.Console.WriteLine("Введите любое положительное число: ");
number = int.Parse(Console.ReadLine());
for (int i = 1; i<= number; i++)
{
    Console.WriteLine($" {i} в кубе: {Math.Pow(i, 3)} ");
}