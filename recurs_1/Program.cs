// Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


string printNumbers(int a, int b)
{
    if(a<=b)
    {
        string numbers = a.ToString();
        string new_numbers = printNumbers(a+1, b);
        if (new_numbers != "")
        {
            numbers+= " " + new_numbers;
        }
        return numbers;
    }
else
{
    return "";
}
   
}




Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
string result = printNumbers(a, b);
Console.WriteLine("Результат: " + result);