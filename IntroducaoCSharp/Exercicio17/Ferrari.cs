using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class Ferrari : Carro
    {
        public Ferrari(string placa ) {
            this.placa = placa;
        }

        public override void mostrarPlaca()
        {
            base.mostrarPlaca();
        }
    }
}
