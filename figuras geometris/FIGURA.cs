using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_geometris
{
    internal class FIGURA // CLASE PADRE 
    {
        /*CLASE QUE EL INGRESO DE UN LADO
         * PARA PODER CREAR UNA NUEVA FIGURA GEOMTRICA
         * RECUERDA QUE UNA FIGURA PARA EXISTIR MINIMO UN LADO 
         * ESTA CLASE ES UN MOLDE 
         * */
        /*DECLARAMOS VARIABLES QUE SE VA A PASAR A LAS CLASES HIJAS NOS SERVIRAN PARAGUARDAD EN LA CAJA DE MEMORIA EL VALOR DEL PRIMER LADO */
        //LA VARIABLE SERA PRIVADA
        private float LADO1; // PERMITE DECIMALES
        //CREAMOS ATRIBUTOS O PROPIEDADES 
        //DEFINIMOS EL CONSTRUCTOR
        private float lado1;
        { /*meotodo o modificardo 
           * para ponel el 
           * valor (#) en la caja 
           * memoria */
            set//poner valor 
            {//pregunta si el lado <0
                if (value < 0) ;
                {
                    LADO1 = 0; //manda el valor a 0
                    //no existen lados nehativod
                  //
                }
                else
                { LADO1 = value;
                    //value es el valor del textbox 
                }

            }


            get// OBTENER VALOR 
            {
                return LADO1; // REGRESA O CAHCA EL VALOR DEL 
            }
        }
    }
    // definimos metodos, funciones, operaciones de las clase padre que tambien van a tener hijos 
    public abstract float area();
    public abstract float perimetro();
    public abstract float volumen();
