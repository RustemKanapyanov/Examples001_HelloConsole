// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 1523;
// int b1 = 21;
// int c1 = 3922;
// int a2 = 12;
// int b2 = 23;
// int c2 = 333;
// int a3 = 13;
// int b3 = 2323;
// int c3 = 33;

// int max =Max 
//         (Max(a1, b1, c1),
//         Max(a2, b2, c2),
//         Max(a3, b3, c3));

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
// Console.WriteLine(max);
// if( b1 > max ) max = b1;
// if( c1 > max ) max = c1;
// if( a2 > max ) max = a2;
// if( b2 > max ) max = b2;
// if( c2 > max ) max = c2;
// if( a3 > max ) max = a3;
// if( b3 > max ) max = b3;
// if( c3 > max ) max = c3;

//1 Вид
// void Method()
// {
//     Console.WriteLine("Автор ...");
// }
// Method();


//2 Вид
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//Method21(msg: "новый текст", count: 4);
//Method21(count: 4, msg: "новый текст");

//вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

//Вид 4
// String Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
    
//     while(i < count)
//     {
//     result = result + text;
//     i++; 
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// String Method4(int count, string text)
// {
//     ;
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text; 
//     }
//     return result;
// }
// string res = Method4(3, "asdf");
// Console.WriteLine(res);

// Таблица умножения с циклом for
// for (int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j<= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// Работа с текстом 
// Дан текст. В тексте нужно все побелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькми "с".

// Ясна ли задача ?

// string text = "- Я думаю, - сказал князь, улыбаясь, -что "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом солгасие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю ?";
// // string s = "qwerty"
// //             012345
// // s[3] //r

// string Replase(string text, char oldValue,char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result +$"{newValue}";
//         else result = result + $"{text[i]}"; 
//     }
//     return result;
// }
// string newText = Replase(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replase (newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replase (newText, 'с', 'С');
// Console.WriteLine(newText);


// Найти позицию минимального элемента в не отсортированной части массива 
// Произвести обмен этого значения со значением первой неосортированной позиции
// Повторять пока есть не отсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

// Циклов много не бывает 
// Бывают циклы в циклах 
// Ничего не принимают, ничего не возвращают 1Вид (ключевое слово Void)
// Что-то принимают, ничего не возвращают 2 Вид(ключевое слово Void)
// Ничего не принимают, что-то возвращают (характерезуются тем типом данных значение которых будет возвращаться)
// Что-то принимают, что-то возвращают (характерезуются тем типом данных значение которых будет возвращаться)
// Может есть и другие ? - точно есть. Сколько ?
// У методов есть входные аргументы