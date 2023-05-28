using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.ConsoleApp1
{
    public class Triangulo
    {
        private int ladoX;
        private int ladoY;
        private int ladoZ;

        public string Tipo;

        private static int quantidadeTriangulos = 0;

        public Triangulo(int ladoX, int ladoY, int ladoZ)
        {
            
            this.ladoX = ladoX;
            this.ladoY = ladoY;
            this.ladoZ = ladoZ;

            quantidadeTriangulos++;
        }

        public string ObterTipo()
        {
            string tipo;

           
            if (LadoXInvalido() || LadoYInvalido() || LadoZInvalido())
                tipo = "Invalido";

            else if (ladoX == ladoY && ladoY == ladoZ)
                tipo = "Eqüilátero";

            else if (ladoX != ladoY && ladoY != ladoZ && ladoZ != ladoX)
                tipo = "Escaleno";

            else
                tipo = "Isósceles";

            return tipo;
        }

        private bool LadoZInvalido()
        {
            bool ladoZInvalido = ladoZ > ladoX + ladoY;

            return ladoZInvalido;
        }

        private bool LadoYInvalido()
        {

            bool ladoXInvalido = ladoX > ladoZ + ladoY;

            return ladoXInvalido;
        }

        private bool LadoXInvalido()
        {

            bool ladoYInvalido = ladoY > ladoZ + ladoX;

            return ladoYInvalido;
        }
    }
}
