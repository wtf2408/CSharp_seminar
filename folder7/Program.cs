// using System.Collections.Generic;

// Console.WriteLine("Введите число которое нужно перевести в двоичную систему : ");
// bool isParsed = int.TryParse(Console.ReadLine(), out int n);
// if (!isParsed)
// {
//     Console.WriteLine("error");
//     return;
// }
// int number = n;
// List<int> result = ConvertToBinary(n);
// result.Reverse();

// Console.Write($"В двоичной системе {number} = ");
// foreach (int item in result)
// {
//     Console.Write(item);
// }


// List<int> ConvertToBinary(int a);
// {
//     List<int> numbers = new List<int>();
//     while (a > 0)
//     {
//         if (a % 2 == 0)
//         {
//             numbers.Add(0);
//         }
//         else
//         {
//             numbers.Add(1);
//         }
//         a /= 2;
//     }
    
//     return numbers;
// }



string result = ConvertToBinary(4);
Console.WriteLine(result);
string  ConvertToBinary(int n)
{
    string res = "";
    while (n>0)
    {
        int x = n % 2;
        n /= 2;
        res = x.ToString() + res;

    }
    return res;
}
