using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Tren : ITransporte, IGuardarEnBD
        /*Tiene varios puntos que no estrìan desarrollados optimamente, en primer lugar:
         * Esta clase se encarga de màs de una funciòn, es decir tiene funciones relacionadas que podrìan utilizarse de esa manera, pero tambièn tiene una funciòn de permanencia
         * en ese caso se estarìa violando el Principio de Responsabilidad Ùnica. Por otro lado hay una clase que se està aplicando y no retorna nada, por lo cual se està violando el Principio 
         de Segregaciòn de Clases, se deberìa generar una nueva Interfase en donde separar esta clase de ese mètodo, y tambièn se esta violando el Principio de Lisov, porque estamos 
        aplicando un mètodo que no devuelve nada, se deberia generar una nueva clase que sea Volar para poder llamarla cuando sea necesario */
    {
        public string _nombre;
        public int _velocidadActual;
        public int _velocidadMaxima;

        public void Acelerar(int velocidad)
        {
            if ((this._velocidadActual + velocidad) <= this._velocidadMaxima)
            {
                this._velocidadActual += velocidad;
            }
        }

        public void Desacelerar(int velocidad)
        {
            if ((this._velocidadActual - velocidad) >= 0)
            {
                this._velocidadActual -= velocidad;
            }
            else
            {
                this._velocidadActual = 0;
            }
        }
        /*Este procedimiento pasarìa a ser una interface que no debe implementarse y como acà no devuelve nada, lo elimino*/
      /* public void Volar(int altitud)
        {
            return;
        }

       
    }*/ //se elimina de aca
}