using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Services
{
    public class HelpServices
    {
        private IElectronics[] _electronics;
        private int _electronicsLength = 0;
        private int _electronicsCounter = 0;

        public HelpServices()
        {
            Electronics = new IElectronics[1];
        }

        public IElectronics[] Electronics
        {
            get { return _electronics; }
            set { _electronics = value; }
        }

        public void Add(IElectronics electronicsUnit)
        {
            _electronicsLength++;
            Array.Resize(ref _electronics, _electronicsLength);

            for (var i = _electronicsCounter; i < _electronicsLength; i++)
            {
                _electronics[i] = electronicsUnit;
                _electronicsCounter++;
            }
        }

        public void FindUnitByName(string name)
        {
            HomeItems items = new HomeItems();
            items.Electronics = _electronics;
            var res = items.Electronics.FindByName(name);
            Console.WriteLine($"I found this item: {res.Name}");
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
                Console.WriteLine(item.Name.PadRight(17) + item.PowerConsumption + "kw");
            }
        }

        public void DisplayQuantity()
        {
            Console.WriteLine($"Total quantity electronics at home: {_electronicsCounter}");
        }

        public void DisplaySort()
        {
            Console.WriteLine("Sort by Power Consumption from MAX to MIN");
            Array.Sort(_electronics);
            Array.Reverse(_electronics);
            DisplayWithPower();
        }
    }
}
