// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// Создаем метод формирования случайного массива чисел от 0 (left) до 150 (right)


int[] RandArray (int sizeArr, int left, int right) 

   
        {
            int[] array = new int[sizeArr];

            for(int i = 0; i < sizeArr; i++)
                   
                {                     
                    array[i] = new Random().Next(left, right);   
                }

        return array;
        }
// Создаем метод поиска в массиве количества элементов, удовлетворяющих заданным условиям: числа от 10 (leftR) до 99 (rightR)

int CountElementsOfSegment (int[] arr, int leftR, int rightR) 

   
        {
            
            int count = 0;

            foreach (int item in arr)
            {
                
                    {                     
                        if (item >= leftR && item <= rightR) count++;   
                    }
            }

        return count;
        }

//const int size = 123;
// вводим константы согласно условию задачи: основной массив: от 0 до 150, значения искомых чисел - от 10 до 99
const int size = 123;
const int left = 0;
const int right = 151;

const int leftR = 10;
const int rightR = 99;

int[] massive = RandArray(size, left, right);
Console.WriteLine($"наш массив, в котором числа принимают значения от {left} до {right - 1} имеет вид: ");
Console.WriteLine();

Console.WriteLine(string.Join(", ", massive));
Console.WriteLine();

int totalCount = CountElementsOfSegment(massive, leftR, rightR);
Console.WriteLine($"количество чисел, принадлежащих отрезку: от {leftR} до {rightR} составляет: {totalCount}");