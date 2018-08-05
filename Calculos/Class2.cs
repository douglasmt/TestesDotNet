using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public class Class2
    {
        public int MinimalNumberOfPackages(int items, int availableLargePackages, int availableSmallPackages)
        {
            try
            { 
                int quantLarge = availableLargePackages * 5;

                int quantSmall = items - quantLarge;
                int total = availableLargePackages + quantSmall;

                return total;
                //return Pacotes;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        
    }
}

