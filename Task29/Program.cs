//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]
//6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]

Main();

void Main()

{
    int[] Arr = {1,1,1,1,1,1,1,1};
    RandArray(Arr);
    PrintArr(Arr);
}

void RandArray(int[] num)
{
    
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(0, 100);
    }
}
   
void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" [{array[i]}] ");
    }
    Console.WriteLine();  
}
