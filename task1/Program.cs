/*
Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


Console.WriteLine("Введите пятизначное число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] array = userNumber.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
int Lenght = array.Length;

if (array.Length == 5)
{
    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine ($"Введенное число является палиндромом");
    }
    else
    {
        Console.WriteLine ($"Введенное число не является палиндромом");
    }    
}
else
{
    Console.WriteLine("Вы ввели неверное значение, введите пятизначное число");
}