// Может ли существовать треугольник со сторонами указанной длины.

Console.WriteLine("Введите длину стороны А");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину стороны B");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину стороны C");
int C = int.Parse(Console.ReadLine());

if ((A < B+C) && (B < A+C) && (C < A+B)) Console.WriteLine("Такой треугольник может существовать");

else Console.WriteLine("Такой треугольник не может существовать");