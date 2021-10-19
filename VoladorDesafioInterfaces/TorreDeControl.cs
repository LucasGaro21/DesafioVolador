using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoladorDesafioInterfaces
{
    class TorreDeControl
    {
        List<IVolador> listaDeVoladores = new List<IVolador>();

        public void vuelenTodos()
        {
            foreach (IVolador i in listaDeVoladores)
            {
                i.volador();
            }
        }

        public void agregarVolador(IVolador unVolador)
        {
            listaDeVoladores.Add(unVolador);
        }
    }
}
