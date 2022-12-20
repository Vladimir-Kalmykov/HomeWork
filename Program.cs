// Задача № 1. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ") ;
int namber1 = int.Parse(Console.ReadLine()!) ;
Console.WriteLine("Введите второе число: ") ;
int namber2 = int.Parse(Console.ReadLine()!) ;

if (namber1 > namber2)
 {
    Console.WriteLine($"Первое  число {namber1} больше Второго числа {namber2}") ;
 }
 else 
 {
 if (namber1 < namber2)  
 {
    Console.WriteLine($"Второе число {namber2} больше первого числа {namber1}") ;
 }
 }

// Задача № 2. Напишите программу, которя принимает на вход три числа и выдает максимальное их этих чисел.

Console.WriteLine("Введите первое число: ") ;
int nam1 = int.Parse(Console.ReadLine()!) ;
Console.WriteLine("Введите второе число: ") ;
int nam2 = int.Parse(Console.ReadLine()!) ;
Console.WriteLine("Введите третье число: ") ;
int nam3 = int.Parse(Console.ReadLine()!) ;
int max = nam1 ;

if (max < nam2)
{
    max = nam2 ;
}

if (max<nam3)
{
    max = nam3 ;
}
Console.WriteLine($"Максимально число {max}") ;

// Задача № 3. Напишите программу, которая на вход принимает число и выдает, являеться ли число четным.

Console.WriteLine("Введите число: ");
int nam = int.Parse(Console.ReadLine()!);

if (nam % 2 == 0)
{
    Console.WriteLine("Число четное") ;
}    
else
{
    Console.WriteLine("Число не четное") ;
}

// Задача № 4. Напишите прогамму,котороя на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($" {i} ");
    }
    i++ ;
}