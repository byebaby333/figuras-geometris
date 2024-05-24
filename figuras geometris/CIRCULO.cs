using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_geometris
{
    internal class CIRCULO:FIGURA // ESTA ES UNA CLASE HIJA DE FIGURA
    {
        // USAM SEL CONSTRUCTOR DE LA CLASE PADRE
        public CIRCULO(float radio)
        { // radio se va a leer de la caja de texto con 
            //usando el boton guardar
            LADO1 = radio;
        }
        //VAMOS A USAR LOS METODOS DE LA CLASE PADRE 
        //VAMOS A SOBREESCRIBIR EL COMPORTAMIETO DE ESTOS 
        public override float area()
        {
            return 3.1416F * LADO1 * LADO1; //AGREGAMOS F CUADNO  ES UNA CONSTATE NO DEFINIDA ENUNA VARIABLE PREVIAMNET, ASI EL PROGR,A SABE QUUES UN #
        }
        public override float perimetro()
        {
            return 3.1416F * 2 * LADO1; 
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            // esto es una exepcion de uso default del sistema
        }

    }
}
