// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ak(m, n);

Console.WriteLine($"Функция Аккермана = {functionAkkerman} ");

int Ak(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ak(m - 1, 1);
  else return Ak(m - 1, Ak(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}