using System;
namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sum, z;
            Console.WriteLine("Введите любое целое число:");
            x = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            z = 0;
            if (x > 0)
            {
                while (x > 0)
                {
                    z = x % 2; x--;
                    if (z == 0)
                    {
                        sum++;
                    }
                }

            Console.WriteLine("Кол-во чисел кратных двум:" + "\n" + sum);
            Console.ReadKey();
            }
            else
            {
                while (x < 0)
                {
                    z = x % 2; x++;
                    if (z == 0)
                    {
                        sum++;
                    }
                }

            Console.WriteLine("Кол-во чисел кратных двум:" + "\n" + sum);
            Console.ReadKey();
            }
            
        }
    }
}
