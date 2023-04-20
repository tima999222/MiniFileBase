using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFileBase
{
    public class ShowPersonsButton : Button, IRunnable
    {
        public ShowPersonsButton(char id, string caption)
        {
            Id = id;   
            Caption = caption;
        }

        public override void Run()
        {
            Console.Clear();

            bool flag = false;
            StreamReader sr = new StreamReader(@"C:\Users\Тимофей\source\repos\MiniFileBase\data.txt");

            string line = sr.ReadLine();

            do
            {
                Person person = PersonSerializer.DeserializePerson(line);
                Console.WriteLine($"Id: {person.Id} Name: {person.Name}");
                line = sr.ReadLine();

            } while (line != null);

            sr.Close();

            Console.WriteLine("Enter 'esc' to exit...");
            while (flag == false)
            {
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    flag = true;
                }
            }

            Menu menu = new Menu();
            menu.DrawMenu();
            menu.PickButton();
        }
    }
}
