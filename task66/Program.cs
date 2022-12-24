// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < n) {
    int sum = 0;
    int Summ(int M, int N) {
        if (M == N + 1) return 0;
        Summ(M + 1, N);
        sum = sum + M;
        return sum;
    }
    Console.WriteLine(Summ(m,n));
}
else {
    int sum = 0;
    int Summ(int M, int N) {
        if (M == N - 1) return 0;
        Summ(M - 1, N);
        sum = sum + M;
        return sum;
    }
    Console.WriteLine(Summ(m,n));
}