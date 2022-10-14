//Подсчитать сумму цифр в числе

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int i = 0;
int sum = 0;
for (i = 0; n >= 1; i++)
{
    sum += n % 10;
    n = n / 10;
}
Console.WriteLine("Сумма цифр в числе равна " + sum); 

