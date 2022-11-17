// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

int GetZero(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
         sum = sum + 1;
    }
    return sum;
}

int[] array = new int[10];

Console.WriteLine(array.Length);

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введитe числo {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write(array[i] + " , ");
}
 
Console.WriteLine();
int Sum = GetZero(array);
Console.Write($"Количество чисел больше нуля = {Sum}");