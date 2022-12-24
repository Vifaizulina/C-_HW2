// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// (можно использовать индексацию строк)

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();  

Console.WriteLine("введите число");  
int n = Convert.ToInt32(Console.ReadLine()); 

if (n > 99) 
    {
        Console.WriteLine(n.ToString()[2]);
    }
else 
    Console.WriteLine("третьей цифры нет");
