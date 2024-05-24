using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_geometris
{
    internal class CUBO : FIGURA // clase hija de figura 
    {     //ESTA CLASE REQUIERE DOS LADOS
        //CREAMOS LADO 2 
        private float LADO2;
        //CREAR UN CONSTRUCTOR PARA RECTANGULO 
        public float LADO2;
        {
            set//poner valor 
            {//pregunta si el lado <0
                if (value < 0) ;
                {
                    LADO2 = 0; //manda el valor a 0
                               //no existen lados nehativod

                }

                else
                {
                    LADO2 = value;
                    //value es el valor del textbox 
                }

            }


            get// OBTENER VALOR 
            {
                return LADO2 // REGRESA O CAHCA EL VALOR DEL 
            }

        }

        // USAM SEL CONSTRUCTOR DE LA CLASE PADRE

        public CUBO(float LADO1)
        { // radio se va a leer de la caja de texto con 
          //usando el boton guardar
            this.LADO1 = LADO1;//HACE QUE UNICAMENTE EL VALOR LACANTIDAD DEL LADO SEA POSIBLE PARA LA CLASE RECTANGULO, CUANDO NO SE USE RECTANGULO LA VARIABLE SERA =0

        }
        //VAMOS A USAR LOS METODOS DE LA CLASE PADRE 
        //VAMOS A SOBREESCRIBIR EL COMPORTAMIETO DE ESTOS 
        public override float area()  //A = 6(X)^2
        {
            return (LADO1 * 6) ^ 2; //AGREGAMOS F CUADNO  ES UNA CONSTATE NO DEFINIDA ENUNA VARIABLE PREVIAMNET, ASI EL PROGR,A SABE QUUES UN #
        }
        public override float perimetro() //P =  12(X)^2
        {
            return (LADO1 * 12)^2;
        }
        public override float volumen() //V= L*3
        { //(LADO1 ^ 3);
            throw new NotImplementedException(); // esto es una exepcion de uso default del sistema
        }
    }
}