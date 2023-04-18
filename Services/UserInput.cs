using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Services
{
    public class UserInput
    {
        private int number;
        public void InputStart()
        {
            Console.WriteLine("What electonics need to be pluged-in?");
            while (true)
            {
                Console.Write("Type the digit of Electronics: ");
                string text = Console.ReadLine();
                if (int.TryParse(text, out number))
                {
                    IElectronics[number].Add();
                    break;
                }
                Console.WriteLine("Try again");
            }
        }
    }
}
