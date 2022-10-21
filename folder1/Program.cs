int GetRundomNumber(int minn, int maxn)
{
    int rundomNumber = new Random().Next(minn,maxn);  
    return rundomNumber;
}
int rundomNumber = GetRundomNumber(10,100);
Console.WriteLine(rundomNumber);


int FindMaxNumber(int number)
{
    int max = number%10;
    int maxtwo = number/10;
    if (maxtwo>max)
    {
        max=maxtwo;
    }
    return max;
}
int max = FindMaxNumber(rundomNumber);
Console.WriteLine(max);