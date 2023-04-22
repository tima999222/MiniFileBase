using System;

namespace MiniFileBase
{
    public class Menu
    {
        private IButton[] buttons = { new ShowPersonsButton('a', "Вывести информацию"), new AddPersonButton('b', "Добавить информацию") };

        public void DrawMenu()
        {
            Console.Clear();

            foreach(var button in buttons)
            {
                Console.WriteLine(button.Id + ". " + button.Caption);
            }
        }

        public void PickButton()
        {
            switch(Console.ReadKey().Key)
            {
                case ConsoleKey.A:
                    buttons[0].Run();
                    break;
                case ConsoleKey.B:
                    buttons[1].Run();
                    break;
            }
        }
    }
}
