/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] InputArray()
{
    Console.WriteLine("Введите количество чисел: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] arrayM = new int[m];
    int i = 0;
    Console.WriteLine("Введите чисело: ");
    while (i < m)
    {
        arrayM[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
return arrayM;
}

void Compare(int[] array)
{
    int n=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
            n++;
    }
    Console.WriteLine($"Чисел больше 0 = {n}.");
}

int[] arrayM=InputArray();
Console.WriteLine("[" + string.Join(", ", arrayM)+ "]" );
Compare(arrayM);
