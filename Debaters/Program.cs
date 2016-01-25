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
                Acces = int.TryParse(currentnumber, out userNumber);
                if (userNumber <= 0)
                {
                    Acces = false;
                }
                if (!acces)
                {
                    Console.WriteLine("Ошибка ввода");
                }
                Console.Clear();
            } while (!acces);

            var Jay = new Jay();
            var SilentBob = new SilentBob();
            var Numbertone = new Numbertron();

            Numbertone.NewNumber += Jay.FetchNewNumber;
            Numbertone.NewNumber += SilentBob.FetchNewNumber;

            Random random = new Random();
            for (int i = 0; i < userNumber; i++)
            {
                Numbertone.Generate(random);
                int a = random.Next(0,100);
            }

            if (Jay.Score > SilentBob.Score)
            {
                Console.WriteLine("Джэй одерживает победу");
            }

            if (Jay.Score < SilentBob.Score)
            {
                Console.WriteLine("Боб одерживает победу");
            }

            if (Jay.Score == SilentBob.Score)
            {
                Console.WriteLine("DRAW");
            }
            Console.ReadKey();
        }
    }
}
