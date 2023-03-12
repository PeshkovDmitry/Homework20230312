// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом 

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 9999 && n < 100000) {
    Console.Write($"{n} ->");
    int n5 = n%10;
    n = n/10;
    int n4 = n%10;
    n = n/10;
    int n3 = n%10;
    n = n/10;
    int n2 = n%10;
    n = n/10;
    int n1 = n;
    if (n1 == n5 && n2 == n4) {
        Console.WriteLine("да");
    } else {
        Console.WriteLine("нет");
    }
} 
else {
    Console.WriteLine("Число не пятизначное");
}

