using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Services
{
    public class UserInput
    {
        private IElectronics[] _electronics;
        private IElectronics[] _turnOnDevices = new IElectronics[0];
        private int _turnOnLength = 0;
        private int _turnOnCounter = 0;
        private IElectronics[] temp;

        public UserInput(IElectronics[] elList)
        {
            _electronics = elList;
        }

        public void Transfer()
        {
            ChooseDevice();
        }

        public void ChooseDevice()
        {
            while (_electronics.Length > 0)
            {
                    Console.WriteLine("Выберите устройства, которые хотите включить:");
                    int j = 1;
                    foreach (var item in _electronics)
                    {
                        Console.WriteLine($"{j}. {item.Name.PadRight(17)}{item.PowerConsumption}kw");
                        j++;
                    }
                
                while (true)
                {
                    string? text = Console.ReadLine();
                    if (int.TryParse(text, out int number))
                    {
                        if (number > 0 && number <= _electronics.Length)
                        {
                            TurnOnDevice(_electronics[number - 1]);
                            
                            temp = new IElectronics[_electronics.Length];
                            for (int k = 0; k < _electronics.Length; k++)
                            {
                                if (_electronics[k] == _electronics[number - 1])
                                {
                                    continue;
                                }
                                else
                                {
                                    temp[k] = _electronics[k];
                                }
                            }
                            _electronics = temp;
                            Array.Sort(_electronics);
                            Array.Reverse(_electronics);
                            Array.Resize(ref _electronics, _electronics.Length - 1);

                            break;
                        }

                        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                    }
                }

            }

        }

        public void TurnOnDevice(IElectronics device)
        {
            Console.WriteLine($"Устройство {device.Name} включено");
            _turnOnLength++;
            Array.Resize(ref _turnOnDevices, _turnOnLength);

            for (var i = _turnOnCounter; i < _turnOnDevices.Length; i++)
            {
                _turnOnDevices[i] = device;
                _turnOnCounter++;
            }
        }
    }
}
