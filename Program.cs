// HomeWork_1
Console.WriteLine("Hello, friend!");
/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.Write("Input first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int second = Convert.ToInt32(Console.ReadLine());

if (first > second) {
    Console.WriteLine($"First number {first} bigger that second {second}");
}
else if (first < second) {
    Console.WriteLine($"Second number {second} bigger that first number {first}");
}
else if (first == second) {
    Console.WriteLine("Equal numbers");
}
else {
    Console.WriteLine("Something wrong");
}
*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Input the first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int third = Convert.ToInt32(Console.ReadLine());

if (first > second && first > third) {
    Console.Write($"First number is the biggest: {first}");
}
else if (second > first && second > third) {
    Console.Write($"Second number is the biggest: {second}");
}
else if (third > first && third > second) {
    Console.Write($"Third number is the biggest: {third}");
}
else Console.WriteLine("Something wrong");