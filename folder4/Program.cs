double StraightLength (int x1, int y1, int x2, int y2)
{
    double length = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return length;
}


Console.WriteLine("Введите координаты первой точки: ");
bool a = int.TryParse(Console.ReadLine(), out int userx1);
bool b = int.TryParse(Console.ReadLine(), out int usery1);


Console.WriteLine("Введите координаты второй точки: ");
bool c = int.TryParse(Console.ReadLine(), out int userx2);
bool d = int.TryParse(Console.ReadLine(), out int usery2);

double result = StraightLength(userx1, usery1, userx2, usery2);
if (result==0)
{
    Console.WriteLine("error");
}
else
{
    Console.WriteLine(result);
}
  

