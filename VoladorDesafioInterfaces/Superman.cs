using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoladorDesafioInterfaces
{
    class Superman : IVolador
    {
        public void volador()
        {
            Console.WriteLine("Estoy volando como un campeón...");
        }
    }
}

