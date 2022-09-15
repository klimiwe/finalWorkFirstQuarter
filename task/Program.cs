/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*/
string [] array = {"Russia", "Denmark", "Kazan"};
int maxLengthOfElemet = 3;
PrintArray (array);

string [] resultArray = ChangeArray (array, maxLengthOfElemet);
PrintArray (resultArray);

void PrintArray(string [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
   Console.WriteLine("]");
}


 string [] ChangeArray (string [] array, int maxLengthOfElemet)   
 {
    int n=0;
for (int i =0; i<array.Length; i++)
{
    if (array[i].Length<=maxLengthOfElemet) {n++;}
}
string [] resultArray = new string [n]; 
int k=0;
for (int j =0; j<array.Length; j++)
{
    if (array[j].Length<=maxLengthOfElemet) {resultArray[k]= array[j]; k++;}
}
return resultArray;
 }