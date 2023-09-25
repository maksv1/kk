class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Выберите программу для выполнения:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Закрыть программу");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    GuessNumberGame();
                    break;
                case 2:
                    MultiplicationTable();
                    break;
                case 3:
                    PrintDivisors();
                    break;
                case 4:
                    Console.WriteLine("Программа закрыта");
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        } while (choice != 4);
    }
     
    static void GuessNumberGame()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 100);
        int attempts = 0;
        int guess;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадал число от 0 до 100. Попробуйте угадать.");

        do
        {
            Console.Write("Введите ваше предположение: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < randomNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                Console.WriteLine("Угадал!", randomNumber, attempts);
            }
        }
        while (guess != randomNumber);
    }

    static void MultiplicationTable()
    {
        Console.WriteLine("Таблица умножения:");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0} * {1} = {2}\t", i, j, i * j);
            }
            Console.WriteLine();
        }
    }

    static void PrintDivisors()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Делители числа {0}:", number);

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}