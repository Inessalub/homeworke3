//Написать программу вычисления произведения чисел от 1 до N
//Показать кубы чисел, заканчивающихся на четную цифру



Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()?? "0");
int i = 1;

for (i = 1; i <= N; i++)
{
    Console.WriteLine(i * i * i);
}
