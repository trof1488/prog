namespace _3Programm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = 0;
            while (q < 1)
            {
                Console.WriteLine("Выберите одну из трех программ:\n" +
                "1-Угадай число\n" +
                "2-Таблица Умножения\n" +
                "3-Делители числа\n" +
                "4-Закончить работу программы");
                int nomer = Convert.ToInt32(Console.ReadLine());
                if (nomer == 1)
                {
                    chislo();
                }
                if (nomer == 2)
                {
                    tabl();
                }
                if (nomer == 3)
                {
                    delitel();
                }
                if (nomer == 4)
                {
                    break;
                }
            }
        }
        static void chislo()
        {
            Random random = new Random();
            int a = random.Next(0, 100);
            Console.WriteLine("Угадайте число то 0 до 100.");
            int b = Convert.ToInt32(Console.ReadLine());
            while (b != a)
            {
                Console.WriteLine("Вы не угадали.");
                b = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вы угадали.");
        }
        static void tabl()
        {
            int[,] tabl = new int[10, 10];
            for (int i = 1; i < 10; i++)
                for (int j = 1; j < 10; j++)
                    tabl[i, j] = i * j;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                    Console.Write("{0,3}", tabl[i, j]);
                Console.WriteLine();
            }
        }
        static void delitel()
        {
            Console.WriteLine("Введите число, у которого хотите узнать делители.");
            int chis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Делители числа:");
            for (int i = 1; i <= chis; i++)
                if (chis % i == 0)
                {
                    Console.WriteLine(i);
                }
        }
    }
}