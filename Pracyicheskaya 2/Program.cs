int gameNumber = 0;
do
{


    Console.WriteLine("Выберите номер игры: ");

    Console.WriteLine("1 - Угадай число \n2 - Таблица умножения \n3 - Вывод делителей числа \n4 - Выйти из программы");
    gameNumber = Convert.ToInt32(Console.ReadLine());
    switch (gameNumber)
    {
        case 1:
            {
                game1();
                break;
            }
        case 2:
            {
                game2();
                break;

            }
        case 3:
            {
                game3();
                break;

            }
        case 4:
            Console.WriteLine("Спасибо за использование!");
            break;
    }
    static void game1()
    {

        Random rand = new Random();
        int a = rand.Next(100);
        int pravilnoeChislo;
        Console.WriteLine("Я загадал число, попробуй угадай)");
        int chislo = rand.Next(1, 100);
        int i;
        for (i = 0; i < 100; i++)
        {
            Console.WriteLine("Введите число от 1 до 100: ");
            pravilnoeChislo = Convert.ToInt32(Console.ReadLine());
            if (pravilnoeChislo != chislo)
            {
                Console.WriteLine("Подумай ещё");
            }
            if (pravilnoeChislo == chislo)
            {
                Console.WriteLine("Вы угадали!");
                break;

            }

        }
    }
    static void game2()
    {
        int[,] tablicaUmnojeniya = new int[10, 10];
        for (int a = 1; a < tablicaUmnojeniya.GetLength(0); a++)
        {
            for (int b = 1; b < tablicaUmnojeniya.GetLength(1); b++)
            {
                tablicaUmnojeniya[a, b] = a * b;
            }
        }
        for (int a = 1; a < tablicaUmnojeniya.GetLength(0); a++)
        {
            for (int b = 1; b < tablicaUmnojeniya.GetLength(1); b++)
            {
                Console.Write(tablicaUmnojeniya[a, b] + "          ");
            }
            Console.WriteLine();
        }
    }
    static void game3()
    {
        Console.WriteLine("Введите число, чтобы узнать его делители");
        int a = int.Parse(Console.ReadLine());
        for (int i = 1; i < a; i++)
        {
            if (a % i == 0)
            {
                Console.WriteLine(i);
            }
        
        
        }

    }

} while (gameNumber != 4);

