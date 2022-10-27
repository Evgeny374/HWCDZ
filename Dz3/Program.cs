/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом. */

// Console.WriteLine("Введите пятизначное число ");
// int Number = Convert.ToInt32(Console.ReadLine());

// if (Number > 9999 && Number < 100000)
// {
//     int Number1 = Number / 10000;
//     int Number5 = Number % 10;

//     int Number2 = (Number / 1000) % 10;
//     int Number4 = (Number / 10) % 10;

//     if (Number2 == Number4 && Number1 == Number5)
//         Console.WriteLine("Введенное число является палиндромом ");
//     else
//     {
//         Console.WriteLine("Введенное число НЕ является палиндромом ");
//     }
// }
// else
//     Console.WriteLine("Вы ввели не пятизначное число");


/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 3D пространстве. */

// double Koordinata(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double rezult = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
//     return rezult;
// }
// Console.WriteLine("Введите х1: ");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1: ");
// double z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите х2: ");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// double y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z2: ");
// double z2 = Convert.ToInt32(Console.ReadLine());
// double rez = Koordinata(x1, y1, z1, x2, y2, z2);
// Console.WriteLine("Расстояние между точками= " + rez);

/* Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел
от 1 до N.*/

void KubChisel (int N)
{for (int i = 1; i <= N; i++)
    {
    Console.Write(" " + i + " ");
    Console.WriteLine(" " + i*i*i + " ");
    }
}
Console.WriteLine("Введите число ");
int n  = Convert.ToInt32(Console.ReadLine());
KubChisel(n);