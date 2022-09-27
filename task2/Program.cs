
/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double distance()

{
    Console.WriteLine("Точка A координаты Х");
    int tochka_1X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка A координаты Y");
    int tochka_1Y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка A координаты Z");
    int tochka_1Z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка B координаты Х");
    int tochka_2X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка B координаты Y");
    int tochka_2Y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Точка B координаты Z");
    int tochka_2Z = Convert.ToInt32(Console.ReadLine());

    double result = Math.Pow((Math.Pow(tochka_2X - tochka_1X, 2) + Math.Pow(tochka_2Y - tochka_1Y, 2) 
    + Math.Pow(tochka_2Z - tochka_1Z, 2) * 1.0), 0.5);
// double - нецелый тип данных
    return result;
//Math.Pow - возведение в степень (что возводим, затем "," и в какую степень)
}
double result = distance();
Console.WriteLine(result);


