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

// Создаем методы определения максимального и минимального значений массива
// Сильно туплю и не понимаю как их объединить в один метод, не используя сортировку )))

int MaxNumber(int[] arr) 
           
        {            
           
            int max = 0;
           
        
            for (int i = 1; i < arr.Length; i ++)
            {               
                                       
                      if (arr[i] > arr[max]) {                          
                    
                        max = i;                                       
        
                     }                     
                
            }

        return arr[max];
        }

        int MinNumber(int[] arr) 

           
        {           
           
            int min = 0;          
        
            for (int i = 1; i < arr.Length; i ++)
            {               
                                       
                      if (arr[i] < arr[min]) {                          
                    
                        min = i;                                       
        
                     }                     
                
            }

        return arr[min];
        }
        
int[] massive = RandArray(10, 0, 100);
Console.WriteLine(string.Join(", ", massive));

int maxs = MaxNumber(massive);
int mins = MinNumber(massive);
int diff = maxs - mins;

Console.WriteLine($" Максимальное число {maxs}");
Console.WriteLine($" Минимальное число {mins}");
Console.WriteLine($" Разница максимального и минимального чисел составляет:  {diff}");

