// задача 40 - HARD необязательная.На вход программы подаются три 
// целых положительных числа. Определить , является ли это сторонами 
// треугольника. Если да, то вывести всю информацию по нему - площадь,
// периметр, значения углов треугольника в градусах, является ли он 
// прямоугольным, равнобедренным, равносторонним.
Console.WriteLine("Введите 1ую сторону треугольника ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2ую сторону треугольника ");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3ую сторону треугольника ");
double c = Convert.ToInt32(Console.ReadLine());
if (a + b > c && a + c > b && b + c > a)
    Console.WriteLine("Треугольник с такими сторонами возможен");
else
{
    Console.WriteLine("Это точно не треугольник");
}
double P = a + b + c;
Console.WriteLine($"Периметр треугольника равен {P}");
double S = Math.Sqrt((P / 2) * (P / 2 - a) * (P / 2 - b) * (P / 2 - c));
Console.WriteLine($"Площадь треугольника равна {S}");
double Alfa = Math.Round(Math.Acos(((a * a + b * b - c * c) / (2 * a * b))) * 57.295779513, 2);
Console.WriteLine($"Угол Альфа равен {Alfa} градусов");
double Betta = Math.Round(Math.Acos((b * b + c * c - a * a) / (2 * c * b)) * 57.295779513, 2);
Console.WriteLine($"Угол Бетта равен {Betta} градусов");
double Gama = Math.Round(Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 57.295779513, 2);
Console.WriteLine($"Угол Гама равен {Gama} градусов");
if (Alfa == Betta && Betta == Gama)
{
    Console.WriteLine("Треугольник равносторонний");
}
else if (Alfa == Betta || Betta == Gama || Gama == Alfa)
{
    Console.WriteLine("Треугольник равнобедренный");
}

else if (Alfa == 90 || Betta == 90 || Gama == 90)
{
    Console.WriteLine("Треугольник прямоугольный");
}

