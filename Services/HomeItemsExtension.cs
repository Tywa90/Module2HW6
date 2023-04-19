using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Services
{
    public static class HomeItemsExtension
    {
        public static IElectronics FindByName(this IElectronics[] units, string name)
        {
            foreach (var item in units)
            {
                if (item.Name != null && item.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    return item;
                }
            }

            return null;
        }
    }
}
