/*
Задача 39:
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] resultArray = new int [size];
    for (int i = 0; i < size; i++) // i < size = i < resultArray.Length
    {
        resultArray[i] = new Random().Next(minValue, maxValue);
    }
    return resultArray;
}

Console.Write("Введите количество элементов массива: ");
int sizeElement = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray (sizeElement, 0, 100);
Console.WriteLine($"Исходный Массив: [ {String.Join("; ", array)} ]");

/* Способ №1 Через резервный массив
int[] CopyReverseArray (int[] arr)
{
    int[] reverseArr = new int [arr.Length]; // размер копии равен размеру ориг. массива
    for (int left = 0, right = arr.Length - 1; left < reverseArr.Length; left++, right--)
    {
        reverseArr[left] = arr[right]; // reverseArr[0] = arr[1], reverseArr[1] = arr[0]
    }
    return reverseArr;
}
int[] reverse = CopyReverseArray(array);
Console.WriteLine($"Обратный Массив: [ {String.Join("; ", reverse)} ]");
*/
// Способ №2 Через вспомогательную переменную
void ReverseArray(int[] arr)
{
for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
{
    int temp = arr[i]; // Для массива arr [10,20,30]; temp = arr[0] => temp = 10
    arr[i] = arr[j]; // arr[0] = arr[2] : [arr[2],20,arr[2]] => [30,20,30]
    arr[j] = temp; // [30,20,temp] : temp = 10 => [30,20,10]
}
}
ReverseArray(array);
Console.WriteLine($"Обратный Массив: [ {String.Join("; ", array)} ]");