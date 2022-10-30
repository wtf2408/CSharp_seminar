Console.Clear();
Console.WriteLine("Введите два числа:  ");

bool x1 = int.TryParse(Console.ReadLine(), out int x);
bool y1= int.TryParse(Console.ReadLine(), out int y);
int quarter = 0;


int DefinitionOfQuarter (int x, int y)
{
    if (x>0 && y>0)
    quarter = 1;
    if (x<0 && y>0)
    quarter = 2;
    if (x<0 && y<0)
    quarter = 3;
    if (x>0 && y<0)
    quarter = 4;
    return quarter;
}

int result = DefinitionOfQuarter(x,y);
if (result == 0)
{
    Console.WriteLine("  неправильно введены координаты");
}
else
{
    Console.Write(result  );
    Console.WriteLine(" четверть");
}

