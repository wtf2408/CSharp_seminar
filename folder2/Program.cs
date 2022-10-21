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

