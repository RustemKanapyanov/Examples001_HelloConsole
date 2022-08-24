

// string[,] table = new string[2, 5];
// // Для того чтобы обратиться к нужному элементу нам необходимо
// // указать наименование массива сначала индекс строки а затем столбца 
// // String.Empty // по умолчанию для строк инициализация происходит константой Empty
// // table[0,0] table[0,1] table[0,2] table[0,4]
// // table[1,0] table[1,1] table[1,2] table[1,4] // меняется индекс строки
// table[1, 2] = "Слово";

// for (int rows= 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     Console.WriteLine($"-{table[rows, columns]}");
// }

// Метод рекурсии
// void PrintArray(int [,]matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//         Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }
// void FillArray (int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);//[1; 10)
//         }

//     }

// }

// int [,] matrix = new int [3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix); 


// double Factorial (int n)
// {   // 1!= 1 
//     // 0!= 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(5)); // 1*2*3 = 6

// for(int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// f(1) = 1
// f(2) = 1
// f(n) = f(n - 1) + f(n - 2) 
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i} = {Fibonacci(i)}");
}