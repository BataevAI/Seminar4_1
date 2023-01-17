// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Создаем метод формирования случайного массива чисел со значениями: от (left) до (right) 


int[] RandArray (int sizeArr, int left, int right) 

   
        {
            int[] array = new int[sizeArr];

            for(int i = 0; i < sizeArr; i++)
                   
                {                     
                    array[i] = new Random().Next(left, right + 1);   
                }

        return array;
        }

// Создаем метод, который считает сумму элементов, стоящих на нечётных позициях

int CountOddElements (int[] arr) 

   
        {
            
            int count = 0;

            for (int i = 1; i < arr.Length; i += 2)
            {
                
                    {                     
                        count = count + arr[i];   
                    }
            }

        return count;
        }

const int size = 6;
const int left = - 100;
const int right = 100;

int[] massive = RandArray(size, left, right);
Console.WriteLine($"наш массив, в котором числа принимают значения от {left} до {right} имеет вид: ");
Console.WriteLine();

Console.WriteLine(string.Join(", ", massive));
Console.WriteLine();

int totalSum = CountOddElements(massive);
Console.WriteLine($"Сумма элементов на нечетных позициях составляет: {totalSum}");