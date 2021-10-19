using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoladorDesafioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl torre = new TorreDeControl();
            Boeing747 avion = new Boeing747();
            Superman superhombre = new Superman();
            Pato pato = new Pato();

            torre.agregarVolador(avion);
            torre.agregarVolador(superhombre);
            torre.agregarVolador(pato);

            torre.vuelenTodos();
            Console.ReadKey();
        }
    }
}
