// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Создаем метод формирования случайного массива трехзначных чисел

int[] RandArray (int size1) 
        {
            int[] array = new int[Math.Abs(size1)];

            for(int i = 0; i < size1; i++)
                   
                {                     
                    array[i] = new Random().Next(100, 1000);   
                }

        return array;
        }

// Создаем метод подсчета четных чисел в массиве

int EvenNum(int[] arr) 

    {
        int count = 0;

        foreach(int t in arr) 
        {

            if (t % 2 != 1) count++;

        }

        return count;
    }



Console.WriteLine("Внесите размерность массива");

int size = Convert.ToInt32(Console.ReadLine());

int[] arr = RandArray(size);
int number = EvenNum(arr);
Console.WriteLine("наш массив имеет вид: ");
Console.WriteLine();
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine();

Console.WriteLine($"количество четных элементов: {number}");

