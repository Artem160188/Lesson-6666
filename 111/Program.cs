// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("Введите количество элементов массива");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"\nВведите элемент массива под индексом{i}:\t");
    myArray[i] = int.Parse(Console.ReadLine());
}
int result = 0;
foreach (int number in myArray)
{
    if (number > 0)
    {
        result++;
    }
}
Console.WriteLine($"Число элементов больше нуля: {result}");