using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Services
{
    public class HelpServices
    {
        private IElectronics[] _electronics = new IElectronics[1];
        private int _electronicsTotal = 0;
        private int _electronicsCounter = 0;
        public void Add(IElectronics electronicsUnit)
        {
            _electronicsTotal++;
            Array.Resize(ref _electronics, _electronicsTotal);

            for (var i = _electronicsCounter; i < _electronicsTotal; i++)
            {
                _electronics[i] = electronicsUnit;
                _electronicsCounter++;
            }

        }

        public void DisplayElectronicsAtHome()
        {
            foreach (var item in _electronics)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void DisplayWithPower()
        {
            foreach (var item in _electronics)
            {
                Console.WriteLine(item.Name + "\t" + item.PowerConsumption);
            }
        }

        public void DisplayQuantity()
        {
            Console.WriteLine($"The total quantity electronics at home: {_electronicsCounter}");
        }

        public void DisplaySort()
        {
            Console.WriteLine("Sort by Power Consumption from");
            Array.Sort(_electronics);
            Array.Reverse(_electronics);
            DisplayWithPower();
        }
    }
}
