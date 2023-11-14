Console.WriteLine("Введите строку a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец b");
int b = Convert.ToInt32(Console.ReadLine()); 
int[,] result = new int[a, b];
for (int i = 0; i < a; i++){
for (int j = 0; j < b; j++){
        Console.WriteLine("Введите значение элементов");
        result[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
int max = 0;
for (int i = 0; i < a; i++)
{
    for(int j = 0; j < b; j++)
    {
        if (i==j && result[i,j] > max)
                {
         max = result[i,j];
}}}
Console.WriteLine($"максимальный элемент {max}");