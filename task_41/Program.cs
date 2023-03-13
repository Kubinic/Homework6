/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
Console.WriteLine("Введите число через пробел"); 
string [] str = Console.ReadLine().Split(' ');

Count_positive_numbers(str);

void Count_positive_numbers(string [] str){
int count = 0;

    int[] arr = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{ 
    arr[i] = int.Parse(str[i]);
   
}
     

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0){
        count++;
    }
}
Console.Write($"{count} чисел больше 0 ввёл пользователь.");
}
