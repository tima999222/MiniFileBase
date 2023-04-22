using System;

namespace MiniFileBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.DrawMenu();
            menu.PickButton();   
        }
    }
}
