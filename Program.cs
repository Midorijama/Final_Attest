// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] FillArrayFromKeyboard(int n)
{
    string[] array = new string[n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент {i + 1} массива из {array.Length}: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray(string[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item}, ");
    }
    Console.Write("\b\b ");
    Console.WriteLine();
}

Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = FillArrayFromKeyboard(n);
int s = 0;
foreach (string e in array)
{
    if (e.Length <= 3)
        s = s + 1;
}
Console.WriteLine(s);
string[] final_array = new string[s];
for (int i = 0, j = 0; i < array.Length; i++)
    {   
    if (array[i].Length <= 3)
        {
            final_array[j] = array[i];
            j++;
        }
    }
PrintArray(final_array);