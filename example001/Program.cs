// //Найти кубы чисел от 1 до N

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()?? "0");
int i = 1;

for (i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} в кубе = {i * i * i}");
}

