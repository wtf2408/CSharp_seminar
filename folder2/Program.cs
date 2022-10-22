//задача на кратность 
Console.Clear();
Console.Write("Введите два числа:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int ostatok = 0;

int Function (int nA, int nB)
{
    if(nA%nB==0)  ostatok=0;
    else ostatok=nA%nB;
    return ostatok;
}
if (Function(numberA, numberB)==0)
{
    Console.Clear();
    Console.Write("кратно");
}
else
{
    Console.Clear();
    Console.WriteLine(numberA%numberB);
    Console.WriteLine("не кратно");
}



//из трехзначного числа убирается число по середине 
int GetRundomNumber(int minn, int maxn)
{
    int rundomNumber = new Random().Next(minn,maxn);  
    return rundomNumber;
}
int rundomNumber = GetRundomNumber(100,1000);
int number = rundomNumber;

int[] array = new int[3];

int count = 0;
while(count<array.Length)
{
    int lastNumber = number%10;
    array[count]=lastNumber;
    number = number/10;
    count = count+1;
}


Console.WriteLine(rundomNumber);
Console.Write(array[2]);
Console.WriteLine(array[0]);