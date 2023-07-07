Console.WriteLine("Введите число и нажмите Enter");
double a = double.Parse(Console.ReadLine());
for (double count = 1; count < a+1; count++)
{
    if (count % 2 == 0) Console.Write($" {count}");
}