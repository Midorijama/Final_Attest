string[] FillArrayFromKeyboard(int n)    //Функция заполнения массива строк с клавиатуры
{
    string[] array = new string[n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент {i + 1} массива из {array.Length}: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray(string[] arr)    //Функция вывода массива строк 
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
string[] array = FillArrayFromKeyboard(n);    //Заполнение массива с клавиатуры помощью функции
int s = 0;

foreach (string e in array)
{
    if (e.Length <= 3)
        s = s + 1;
}

string[] final_array = new string[s];
for (int i = 0, j = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        final_array[j] = array[i];
        j++;
    }
}

PrintArray(final_array);    //Вывод всех элементов массива с помощью функции
