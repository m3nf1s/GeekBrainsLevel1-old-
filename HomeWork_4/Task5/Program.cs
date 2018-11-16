using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        /*5. **Существует алгоритмическая игра “Удвоитель”.
         В этой игре человеку предлагается какое-то число, а человек должен, управляя роботом “Удвоитель”, достичь этого числа за минимальное число шагов.
         Робот умеет выполнять несколько команд: увеличить число на 1, умножить число на 2 и сбросить число до 1. Начальное значение удвоителя равно 1.
         
            Реализовать класс “Удвоитель”.
         Класс хранит в себе поле current - текущее значение, +
         finish - число, которого нужно достичь,+
         конструктор, в котором задается конечное число.+
         Методы: увеличить число на 1,+
         увеличить число в два раза,+
         сброс текущего до 1,+
         свойство Current, которое возвращает текущее значение,+
         свойство Finish, которое возвращает конечное значение.+
         
            Создать с помощью этого класса игру, в которой компьютер загадывает число, а человек.выбирая из меню на экране,
         отдает команды удвоителю и старается получить это число за наименьшее число ходов.Если человек получает число больше положенного, игра прекращается.*/
        static void Main(string[] args)
        {
            ProjectSettings();
            Console.WriteLine("Добро пожаловать username в игру Удвоитель");
            Redoubler game = new Redoubler();
            int count = 0;
            Console.WriteLine($"Начальное значение = {game.Current}. Тебе надо достичь за минимальное количество шагов - {game.Finish}");
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Доступные команды : 1)Current 2)Finish 3)Add 4)Multi 5)Reset");
            while (game.current < game.finish)
            {
                Console.Write("Введите ваше действие> ");
                try
                {
                    int step = int.Parse(Console.ReadLine());
                    switch (step)
                    {
                        case 1:
                            Console.WriteLine($"Текущее значение = {game.Current}");
                            break;
                        case 2:
                            Console.WriteLine($"Значение, которое надо достигнуть = {game.Finish}");
                            break;
                        case 3:
                            game.Add();
                            break;
                        case 4:
                            game.Multi();
                            break;
                        case 5:
                            game.Reset();
                            break;
                        default:
                            Console.WriteLine("Введенно не правильное действие");
                            break;
                    }
                    count++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (game.current == game.finish) Console.WriteLine($"Поздравляю, username! Вы достигли {game.Finish} за {count} шагов :)"); else if (game.current > game.finish) Console.WriteLine($"{game.current}. Ooops, Вы проиграли :(");
                }
            }
            Console.ReadKey();
        }

        static void ProjectSettings()
        {
            Console.SetWindowSize(130, 40);
            Console.SetBufferSize(130, 150);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Деревянко Андрей GeekUniversity Урок 4: Массивы.Текстовые файлы";
        }
    }
}
