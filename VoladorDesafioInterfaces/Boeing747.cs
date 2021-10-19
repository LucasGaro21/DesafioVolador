using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoladorDesafioInterfaces
{
    class Boeing747 : IVolador
    {
        public void volador()
        {
            Console.WriteLine("Estoy volando como un avión...");
        }
    }
}
