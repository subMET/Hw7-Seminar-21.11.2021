// int[] CreateRandomArray(int N, int min, int max)
// {
//     int[] A = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         A[i] = new Random().Next(min, max + 1);
//     }
//     return A;
// }

void PrintArray(int[] A)
{
    int L = A.Length;
    for (int i = 0; i < L; i++)
    {
        Console.Write($"{A[i]} ");
    }
    System.Console.WriteLine();
}

void PrintArrayDouble(double[] A)
{
    int L = A.Length;
    for (int i = 0; i < L; i++)
    {
        Console.Write($"{A[i]} ");
    }
    System.Console.WriteLine();
}

void PrintFigureOne(int[,] Figure)
{
    for (int i = 0; i < Figure.GetLength(1); i++)
    {
        Console.SetCursorPosition(Figure[0, i], Figure[1, i]);
        System.Console.Write("+");
    }
}

void PrintFigureTwo(int[,] Figure)
{
    for (int i = 0; i < Figure.GetLength(1); i++)
    {
        Console.SetCursorPosition(Figure[0, i], Figure[1, i]);
        System.Console.Write("O");
    }
}

// ==================================================================================================
// 41. Выяснить являются ли три числа сторонами треугольника 
// bool IsTriangle(int a, int b, int c)
// {
//     return !(a >= b + c | b >= a + c | c >= a + b);
// }
// if (IsTriangle(3,4,9)) {System.Console.WriteLine("Треугольник.");}
// else {System.Console.WriteLine("Не треугольник.");}

// ==================================================================================================
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// int CheckArray(int[] A)
// {
//     int count = 0;
//     for (int i = 0; i < A.Length; i++)
//     {
//         if (A[i] > 0) count++;
//     }
//     return count;
// }

// int[] ReadArray(int N)
// {
//     int[] A = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         A[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return A;
// }

// System.Console.WriteLine("Сколько чисел будет введено?");
// int N = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите числа.");
// int C = CheckArray(ReadArray(N));
// System.Console.WriteLine($"Чисел больше 0 = {C}.");

// ==================================================================================================
// 43. Написать программу преобразования десятичного числа в двоичное
// int ToBinary(int d)
// {
//     int b = 0;
//     int c = 1;
//     while (d > 0)
//     {
//         if (d % 2 == 1)
//         {
//             b = b + c;
//         }
//         d = d / 2;
//         c = c * 10;
//     }
//     return b; 
// }

// int d = 0;
// int b = ToBinary(d);
// System.Console.WriteLine(d);
// System.Console.WriteLine(b);

// ==================================================================================================
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// double[] DotOfCross(double k1, double b1, double k2, double b2)
// {
//     double[] A = { 0, 0 };
//     if (k1 == k2 && b1 == b2)
//     {
//         A[1] = b1;
//         System.Console.WriteLine("Прямые совпадают.");
//         return A;
//     }
//     if (k1 == k2 && b1 != b2)
//     {
//         System.Console.WriteLine("Прямые параллельны.");
//         return A;
//     }
//     A[0] = (b2 - b1) / (k1 - k2);
//     A[1] = A[0] * k1 + b1;
//     return A;
// }

// double[] B = DotOfCross(1, 99, 1, 99);
// System.Console.Write("Точка пересечения - ");
// PrintArrayDouble(B);

// ==================================================================================================
// 45. Показать числа Фибоначчи
// int[] FibanacciNumbers(int N)
// {
//     int[] A = new int[N];
//     int a = 0;
//     int b = 1;
//     int c = 0;
//     for (int i = 0; i < N; i++)
//     {
//         A[i] = a;
//         c = b;
//         b = a + b;
//         a = c;
//     }
//     return A;
// }

// int[] A = FibanacciNumbers(10);
// PrintArray(A);

// ==================================================================================================
// 46. Написать программу масштабирования фигуры
// int[,] Scaling(int[,] Coord, int N)
// {
//     int[,] NewCoord = new int[2,Coord.GetLength(1)];
//     for (int i = 0; i < Coord.GetLength(1); i++)
//     {
//         NewCoord[0, i] = N * Coord[0, i];
//         NewCoord[1, i] = N * Coord[1, i];
//     }
//     return NewCoord;
// }

// int[,] Triangle = new int[2, 3];
// Triangle[0, 0] = 0;
// Triangle[1, 0] = 0;
// Triangle[0, 1] = 10;
// Triangle[1, 1] = 0;
// Triangle[0, 2] = 5;
// Triangle[1, 2] = 6;

// Console.Clear();
// int[,] ScaledTriangle = Scaling(Triangle, 2);
// PrintFigureOne(Triangle);
// PrintFigureTwo(ScaledTriangle);

// ==================================================================================================
// 47. Написать программу копирования массива
// int[] CopyArray(int[] A)
// {
//     int L = A.Length;
//     int[] B = new int[L];
//     for (int i = 0; i < L; i++)
//     {
//         B[i] = A[i];
//     }
//     return B;
// }

// int[] B = CopyArray(A);
// PrintArray(B);