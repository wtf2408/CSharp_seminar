// int[] array = {-1,5,-9,4};

// void ChangePositiveNumbersToNegative (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i]*= -1;
//     }
// }

// foreach (int item in array)
// {
//     Console.Write($"{item} ");
// }

// ChangePositiveNumbersToNegative(array);

// Console.WriteLine();
// foreach ( int item in array)
// {
//     Console.Write($"{item} ");
// }

// Console.Write("Введите число: ");
// bool isParsed = int.TryParse(Console.ReadLine(), out int userNumber);
// if(!isParsed)
// {
//     Console.WriteLine("error");
//     return;
// }

// int[] array = { -1, 5, -9, 4 };
// bool result = CheckNumber(userNumber, array);
// if (result)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");

// }



// bool CheckNumber(int n, int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == n)
//         {
//             return true;
//         } 
//     }
//     return false;
// }

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// int[] array = new int[123];
// Random random = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = random.Next (1,200);
// }

// int CountsElements(int[] arr)
// {
//     int count = 0;
//     for (int j = 0; j < arr.Length; j++)
//     {
//         if (arr[j]<100 && arr[j]>9)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// int result = CountsElements(array);
// Console.WriteLine($"Отрезку [10,99] принадлежит {result} чисел из массива:");

// foreach (int item in array)
// {
//     Console.Write($"{item} ");
// }

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21


Random random = new Random();
int length = random.Next(3,10);
int [] array = new int[length];
FillArray(array);
foreach (int item in array)
{
    Console.Write($"{item} ");
}


int len = array.Length / 2;
if (array.Length % 2 != 0)
{

    len ++;
}



int[] array1 = ProductOfNumbersInArray(array, len);
Console.WriteLine();
foreach (int item in array1)
{
    Console.Write($"{item} ");
}


void FillArray( int[] arr)
{
    for (int i = 0; i < length; i++)
    {
        arr[i] = random.Next(1,11);
    }
}

int [] ProductOfNumbersInArray( int[] arr, int leng)
{
        int[] arr1 = new int[leng];
        for (int i = 0; i < leng; i++)
        {
            arr1[i] = arr[i] * arr[arr.Length - 1 - i];
        }
    
    return  arr1;
}



