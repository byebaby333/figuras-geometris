using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_geometris
{
    internal class Triangulo : FIGURA // clase hija de figura 
    {     //ESTA CLASE REQUIERE DOS LADOS
        //CREAMOS LADO 2 
        private float LADO2;
        //CREAR UN CONSTRUCTOR PARA RECTANGULO 
        public float LADO2;
    //esto es un comentario nuevo 10 am
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

        public Triangulo(float LADO1, float LADO2, float LADO3)
        { // radio se va a leer de la caja de texto con 
          //usando el boton guardar
            this.LADO1 = LADO1;//HACE QUE UNICAMENTE EL VALOR LACANTIDAD DEL LADO SEA POSIBLE PARA LA CLASE RECTANGULO, CUANDO NO SE USE RECTANGULO LA VARIABLE SERA =0
            this.LADO2 = LADO2;
            this.LADO3 = LADO3;
        }
        //VAMOS A USAR LOS METODOS DE LA CLASE PADRE 
        //VAMOS A SOBREESCRIBIR EL COMPORTAMIETO DE ESTOS 
        public override float area()  //A = (b * h) / 2
        {
            return (LADO1 * LADO2 / 2); //AGREGAMOS F CUADNO  ES UNA CONSTATE NO DEFINIDA ENUNA VARIABLE PREVIAMNET, ASI EL PROGR,A SABE QUUES UN #
        }
        public override float perimetro() //P = a + b + c
        {
            return LADO1 + LADO2 + LADO3;
        }
        public override float volumen()
        {
            throw new NotImplementedException();/*Un triángulo equilátero con lados de 5 cm tiene un perímetro de 15 cm y un área de A = (5 * 5) / 2 = 12.5 cm².
            Un triángulo rectángulo con lados de 3 cm y 4 cm y altura de 5 cm tiene un área de A = (3 * 5) / 2 = 7.5 cm² y un perímetro de P = 3 + 4 + √(3² +4²) = 7.07 cm.
Un triángulo con lados de 2 cm, 3 cm y 4 cm tiene un perímetro de 9 cm y un área de A = √(9 * (9 - 2) * (9 - 3) * (9 - 4)) = 6 cm²*/
            // esto es una exepcion de uso default del sistema
        }
    }
}
