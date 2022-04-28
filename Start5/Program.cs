// 2. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
//Само расстояние между двумя точками вычисляется по формуле, поиск через Math  

Console.Write("Введите координаты x1: "); // вывод на экран текста
double x1 = double.Parse(Console.ReadLine()); // 3 Преобразует строковое представление числа в 
                                                  // эквивалентное ему число двойной точности с плавающей запятой.

Console.Write("Введите координаты y1: ");
double y1 = double.Parse(Console.ReadLine()); // 6

Console.Write("Введите координаты x2: ");
double x2 = double.Parse(Console.ReadLine()); // 2

Console.Write("Введите координаты y2: ");
double y2 = double.Parse(Console.ReadLine()); // 1

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // Формула нахождения расстояния
                                                                                        // между точками координат
Console.WriteLine($"Расстояние между точками: {result}");                         // выводим результат в консоль
Console.ReadLine();