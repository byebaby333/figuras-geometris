using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_geometris
{
    internal class POLIGONO_REGU : FIGURA
    {
        //declarar dos valores para guaradar numero de lados 
        // y el apotema privados para usarse solo enn sesta calse 
        private float Apo, n;
        public float Apo // validar apotema existen o real 
        {
            //pregunt si el apotema ( es el # del centro del poligono <0
            set
            {
                if (value < 0)
                {
                    Apo = 0; //manda el valor a 0
                             // no existe apotmeas negativos 

                }
                else
                {
                    Apo = value;
                    //value es el valor del textbox

                }

            }
            get  //obtener el valor

            {
                return Apo; //regresa o cacha el valor de la variable 

            }

        }
        public float n // validar el nuemro de lados >5
        {
            //pregunt si el apotema ( es el # del centro del poligono <0
            set
            {   //pregunt si el # DE LADOS (N)  >5
                if (value < 5)
                {
                    n = 5; //manda el valor a 0
                           // no existe apotmeas negativos 

                }
                else
                {
                    n = value;
                    //value es el valor del textbox

                }

            }
            get  //obtener el valor

            {
                return n; //regresa o cacha el valor de la variable 

            }
        }
        public POLIGONO_REGU(float LADO, float Apo, float n)
        {
            //radio se va a leer de la caja de texto con  usando el boton guardar 
            lado1 = LADO;
            Apo = Apo;
            n = n;
        }
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