// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
//является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 1 || a > 7){
	Console.WriteLine("Вы ошиблись!! Введите число: ");
	a = Convert.ToInt32(Console.ReadLine());
}

if (a==1) Console.WriteLine("Нет");
else if (a==2) Console.WriteLine("Нет");
else if (a==3) Console.WriteLine("Нет");
else if (a==4) Console.WriteLine("Нет");
else if (a==5) Console.WriteLine("Нет");
else if (a==6) Console.WriteLine("Да");
else if (a==7) Console.WriteLine("Да");
