using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Debaters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в ЧислоТрон!!! \"Вспышки пламени \"\nЧтобы начать игру введите целое число больше нуля!");
            
            var acces = false;
            int userNumber;
            do
            {
                Console.Write("Ваше число - ");
                var currentnumber = Console.ReadLine();
                acces = int.TryParse(currentnumber, out userNumber);
                if (userNumber <= 0)
                {
                    acces = false;
                }
                if (!acces)
                {
                    Console.WriteLine("Ошибка ввода");
                }
                Console.Clear();
            } while (!acces);

            var jay = new Jay();
            var silentBob = new SilentBob();
            var numbertone = new Numbertron();

            numbertone.NewNumber += jay.FetchNewNumber;
            numbertone.NewNumber += silentBob.FetchNewNumber;

            Random random = new Random();
            for (int i = 0; i < userNumber; i++)
            {
                numbertone.Generate(random);
                int a = random.Next(0,100);
            }

            if (jay.Score > silentBob.Score)
            {
                Console.WriteLine("Джэй одерживает победу");
            }

            if (jay.Score < silentBob.Score)
            {
                Console.WriteLine("Боб одерживает победу");
            }

            if (jay.Score == silentBob.Score)
            {
                Console.WriteLine("DRAW");
            }
            Console.ReadKey();
        }
    }
}
