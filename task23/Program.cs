// задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу кубов чисел от 1 до N  

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{n} -> ");
for (int i = 1; i <= n; i++ ) {
    Console.Write($"{Math.Pow(i,3)} ");   
}