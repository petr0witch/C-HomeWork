// HomeWork_1
Console.WriteLine("Hello, friend!");

/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

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

