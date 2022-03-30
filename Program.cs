using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars_group
{
    class BrsAnswer
    {
        public event EventHandler<char> OnKeyPressed;
        public static ConsoleKeyInfo key;
        public static void displayconsole(Object sender, char c) => Console.WriteLine($"\n Вы ввели: {key.KeyChar}");

        public void Run()
        {
            OnKeyPressed += displayconsole;
            while (true)
            {
                key = Console.ReadKey();                
                if (key.KeyChar == 'c') break;

                OnKeyPressed?.Invoke(this, key.KeyChar);
            }
        }

        static void Main(string[] args)
        {
            var Brs = new BrsAnswer();
            Brs.Run();
        }
        public delegate void EventHandler();
    }
}
