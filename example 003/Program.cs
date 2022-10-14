//Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()?? "0");
int i = 1;
int f = 1;

while (i <= N )
{
    f = f * i;
    i++;
}
Console.WriteLine(f);