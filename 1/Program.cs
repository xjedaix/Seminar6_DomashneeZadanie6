// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3




class Program 
{
    static void Main(string[] args) {
        Console.Write("Введите количество чисел: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < n; i++) {
            Console.Write($"Введите число {i + 1}: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0) {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел, больших 0: {count}");
    }
}