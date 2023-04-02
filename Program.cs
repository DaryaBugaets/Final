// метод ничего не возвращает, принимает на вход одномерный массив 
// печать одномерного массива 
void Print1DArray(string [] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"[{array[i]}]\t");
    }
}
// метод находит строки в массиве длиной не больше count(3) и возвращает новый массив
string [] ThreeArray(string [] array, int count)
{   
    string [] result= new string [0];
    for (int ind = 0; ind < array.Length; ind++)
    {
        if (array[ind].Length<=count)
        {
            result = result.Concat(new string[]{array[ind]}).ToArray();
        }
    }
    return result;    
}
string [] array = new string[]{"Russia","Denmark","Kazan"};
string [] resultarray = ThreeArray(array,3);

Console.WriteLine("Исходный массив:");
Print1DArray(array);
Console.WriteLine();
Console.WriteLine("Массив из строк, длина которых меньше либо равна трем символам:   ");

if(resultarray.Length!=0)
{
    Print1DArray(resultarray);
}
else
{
    Console.WriteLine("выделить массив из трех символов не удалось, такой массив отсутствует");
}
