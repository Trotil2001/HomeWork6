/*Задана целочисленная квадратная матрица размером N x N. 
Требуется транспонировать ее относительно побочной диагонали.

Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное 
число N – количество строк и столбцов матрицы. В каждой из 
последующих N строк записаны N целых чисел – элементы матрицы. 
Все числа во входных данных не превышают 100 по абсолютной величине.

Выходные данные
В выходной файл OUTPUT.TXT выведите матрицу, полученную 
транспонированием исходной матрицы относительно побочной диагонали.

Пример
№	INPUT.TXT	OUTPUT.TXT
1	5
3 4 9 6 2       0 8 7 1 2
8 2 0 5 1       7 3 8 5 6
4 7 4 8 7       3 3 4 0 9
7 1 3 3 8       6 1 7 2 4
5 6 3 7 0       5 7 4 8 3

*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-0, 101);
    }
}


void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            //Console.Write(matrix[i, j] + " \t");
            Console.Write("{0,4}",matrix[i, j]);
        Console.WriteLine();
    }
}


void RealeseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-i-1; j++)
        {
            int tempElem=matrix[i, j];
            matrix[i, j] = matrix[matrix.GetLength(0)-1-j,matrix.GetLength(1)-1-i];
            matrix[matrix.GetLength(0)-1-j,matrix.GetLength(1)-1-i]=tempElem;
        }
    }
}
/*
int[,] matrix=new int[,]
{   {3, 4, 9, 6, 2},
    {8, 2, 0, 5, 1},
    {4, 7, 4, 8, 7},
    {7, 1, 3, 3, 8},
    {5, 6, 3, 7, 0},
};
*/
Console.Write("Введите размер квадратной матрицы N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
InputMatrix(matrix);
PrintMatrix(matrix);
RealeseMatrix(matrix);
PrintMatrix(matrix);

