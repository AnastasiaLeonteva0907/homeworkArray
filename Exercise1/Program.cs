
Console.Clear();

// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива,
//значения которых лежат в отрезке [20,90].

// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());;
// int[] array = new int[n];
// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 101);
// Console.WriteLine(string.Join(", ", array));

// int result = 0;
// for(int i = 0; i < array.Length; i++)
// if(array[i] <= 90 && array[i] >= 20)
// result++;
// Console.WriteLine(result);

// ............................................................................................................

//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 101);
// Console.WriteLine(string.Join(", ", array));

// int result = 0;
// for(int i = 0; i < array.Length; i++)
// if(array[i] % 2 == 0)
// result++;
// Console.WriteLine($"Количество четных чисел: {result}");

// ..........................................................................................................

// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

// Random rnd = new Random();
// double [] array = Enumerable.Range(0, 10).Select(x => rnd.NextDouble() * 10 + 5).ToArray();
// Console.WriteLine(string.Join(", ", array));

// double minValue = array.Min();
// double maxValue = array.Max();

// double Difference = maxValue - minValue;

// Console.WriteLine($"Минимальный элемент: {minValue}");
// Console.WriteLine($"Максимальный элемент: {maxValue}");
// Console.WriteLine($"Разница элементов: {Difference}");

// ...............................................................................................................

// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа.
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

int n = new Random().Next(1, 100000);
Console.WriteLine(n);
Console.Write("Введите колличество элементов числа: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = n % 10;
    n /= 10;
}
Console.WriteLine(string.Join(", ", array));

int [] arr = array;

for (int i = 0; i < arr.Length/2; i++)
{
    int Fix = arr[i];
   arr [i] = arr[arr.Length-i-1];
   arr[arr.Length-i-1] = Fix;
}
Console.WriteLine(string.Join(", ", arr));


