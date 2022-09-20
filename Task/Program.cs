// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.Clear();
string [] array = {"hello", "5236", "K", "-lu", ")))"}; 
string [] newArray = NewArray (array);
PrintArray (newArray);

// возвращает массив из строк, длина которых меньше либо равна 3 символа

string [] NewArray (string [] array)
{
    string[] result = new string[array.Length];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[index] = array[i];  
            index++;    
        }
    }
    return result;
}

// выводит массив в консоль

void PrintArray (string [] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        {
            Console.Write($"{inArray[i]} ");
        }
    }
}