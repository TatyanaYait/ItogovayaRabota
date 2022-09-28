// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами


Console.Write("Введите количество элементов, которое хотите ввести: ");
int m = int.Parse(Console.ReadLine());
string[] strArray = new string[m];
int count = 0;

for (int i = 0; i < m; i++)
{
    Console.Write("Введите элемент массива: ");
    string a = Console.ReadLine();
    strArray[i] = a;
}
// for (int i = 0; i < strArray.Length; i++)
// {
// Console.Write($"{strArray[i]},");
// }

for (int i = 0; i < strArray.Length; i++)
{
    if (strArray[i].Length < 4)
    {
        count++;
    }
}
Console.WriteLine();

string[] Array2 = new string[count];
int j = 0;
for (int i = 0; i < strArray.Length; i++)
{
    if (strArray[i].Length < 4)
    {
        Array2[j] = strArray[i];
        Console.Write($"{Array2[j]},");
        j++;
    }
}