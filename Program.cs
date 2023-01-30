case 1:
int a = 5;
int b = 7;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.Write(max);

int a = 2;
int b = 10;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.Write(max);

int a = -9;
int b = -3;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.Write(max);

case 2:

int a = 2;
int b = 3;
int c = 7;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);


int a = 44;
int b = 5;
int c = 78;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);


int a = 22;
int b = 3;
int c = 9;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);

case 3:

int m;
Console.Write("Введите число : ");
m = int.Parse(Console.ReadLine());
if (m % 2 == 0)
                
{
    Console.Write("Введенное число является четным");
    Console.Read();
}
else
{
    Console.Write("Введенное число нечетное");
    Console.Read();
}

case 4:

Console.Write("Введите число : ");
int.TryParse(Console.ReadLine(), out int n);
var d = 2;
while (d <= n)
{
    Console.Write(i + " ");
    d = d + 2;
}
