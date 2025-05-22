int a = int.Parse(Console.ReadLine());
int ha = int.Parse(Console.ReadLine()); 

static int Triangle(int a, int ha)
{
    return (a * ha) / 2; 
}

int area = Triangle(a, ha);
Console.WriteLine(area);
