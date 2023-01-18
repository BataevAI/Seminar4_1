// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

// Создаем метод разности значений между максимальным и мнимальным значением

int DifferenceMaxAndMin (int[] arr) 

           
        {
            
            int diff = 0;
            int max = 0;
            

            for (int i = 1; i < arr.Length; i ++)
            {
                max = arr[0];
                    {                     
                      if (arr[i + 1] > arr[i]) {   //3 2 1 10 0 5 7 11
                        max = arr[i + 1]; 
                                      
        
                     }
                      
                        else {
                                int temp = arr[i + 1];
                                arr[i + 1] = arr[i];
                                arr[i] = temp;

                        }

                    }
            }

        return max;
        }
        
int[] massive = RandArray(10, 0, 43);
Console.WriteLine(string.Join(", ", massive));

int mas = DifferenceMaxAndMin(massive);

Console.WriteLine($" Максимальное число {mas}");

