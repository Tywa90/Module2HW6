using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Services
{
    public class HelpServices
    {
        private int i = 0;
        private int _electronicsTotal = 1;
        public IElectronics[] _electronics;
        public void Add(IElectronics electronicsUnit)
        {
            Array.Resize(ref _electronics, _electronicsTotal);
            _electronics[i] = electronicsUnit;
            i++;

            _electronicsTotal++;
        }
    }
}
