// 8. Написать программу со следующими командами:
// - SetNumbers – пользователь вводит числа через пробел, а программа запоминает их в массив
// + AddNumbers – пользователь вводит числа, которые добавятся к уже существующему массиву
// + RemoveNumbers -  пользователь вводит числа, которые если  найдутся в массиве, то будут удалены
// + Numbers – ввывод текущего массива
// + Sum – найдется сумма всех элементов чисел
// По желанию можно добавить методов работы с числовыми массивами:
// - найти локальные максимумы
// - вывести статистику чисел (в любом красивом виде)
// - любые дополнительные по желанию

Console.WriteLine("Введите числа через пробел");
string text = Console.ReadLine();

int[] numbers = SetNumbers(text, ' ');

WriteArray(numbers);


int[] SetNumbers(string inputText, char separator)
{
    int[] numbers = new int[1];
    int i = 0;

    string element = string.Empty;
    int number = 0;
    while (inputText[i] == separator)
    {
        i++;
    }
    for (; i < inputText.Length; i++)
    {
        WriteArray(numbers);
        if (inputText[i] == separator)
        {
            if(numbers.Length == 1)
            {
                numbers[0] = number;
                element = string.Empty;
                continue;
            }
            number = Convert.ToInt32(element);
            numbers = AddNumbers2(numbers, number);
            element = string.Empty;
        }
        else
            element += inputText[i];
            Console.WriteLine(element);
    }
    return numbers;

}

numbers = AddNumbers(numbers);

WriteArray(numbers);

numbers = RemoveNumbers(numbers);

WriteArray(numbers);

Sum(numbers);



int ConvInt(string message)
{
    Console.Write(message);

    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] AddNumbers(int[] arrayToAdd)
{
    int addNumber = ConvInt("Введите число, которое хотите добавить в массив: ");

    int size = arrayToAdd.Length;

    int[] addArray = new int[++size];

    for (int i = 0; i < arrayToAdd.Length; i++)
    {
        addArray[i] = arrayToAdd[i];
    }
    addArray[addArray.Length - 1] = addNumber;

    return addArray;
}

int[] RemoveNumbers(int[] delFromArray)
{
    Console.Write("Введите число, которое хотите удалить: ");

    int delNumberIndex = SearchInArray(delFromArray, "");

    if (delNumberIndex < 0)
    {
        return delFromArray;
    }
    int[] delArray = new int[delFromArray.Length - 1];

    int j = 0;
    for (int i = 0; i < delFromArray.Length; i++)
    {
        if (i == delNumberIndex)
        {
            i++;
        }
        delArray[j] = delFromArray[i];
        j++;
    }
    return delArray;
}

int SearchInArray(int[] searchInArray, string message)
{
    int searchNumber = ConvInt(message);

    for (int i = 0; i < searchInArray.Length; i++)
    {
        if (searchInArray[i] == searchNumber)
        {
            searchNumber = i;
            return searchNumber;
        }
    }
    Console.WriteLine("Такого числа в массиве нет.");
    return searchNumber = -1;
}

void Sum(int[] sumArray)
{
    int sum = 0;
    for (int i = 0; i < sumArray.Length; i++)
    {
        sum += sumArray[i];
    }
    Console.WriteLine($"Сумма элементов в массиве: {sum}");
}



int[] AddNumbers2(int[] arrayToAdd, int addNumber)
{
    int size = arrayToAdd.Length;

    int[] addArray = new int[++size];

    for (int i = 0; i < arrayToAdd.Length; i++)
    {
        addArray[i] = arrayToAdd[i];
    }
    addArray[addArray.Length - 1] = addNumber;

    return addArray;
}