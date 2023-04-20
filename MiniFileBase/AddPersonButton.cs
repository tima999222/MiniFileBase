using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFileBase
{
    public class AddPersonButton : Button, IRunnable
    {
        public AddPersonButton(char id, string caption)
        {
            Id = id;
            Caption = caption;
        }

        public override void Run()
        {
            Console.Clear();

            Console.Write("Введите id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Person person = new Person { Id = id, Name = name };

            StreamWriter sw = new StreamWriter(@"C:\Users\Тимофей\source\repos\MiniFileBase\data.txt", true);

            sw.WriteLine(PersonSerializer.SerializeToFile(person));

            sw.Close();

            Menu menu = new Menu();
            menu.DrawMenu();
            menu.PickButton();
        }
    }
}
