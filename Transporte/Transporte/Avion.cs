
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Avion : ITransporte, IVolar, IGuardarEnBD
    {
        public string _nombre;
        public int _velocidadActual;
        public int _velocidadMaxima;
        public int _alturaActual;
        public int _alturaMaxima;

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
        /*Este procedimiento deberia llevarlo a una Interface que sea volar, y Luego implementarla en esta clase que si lo requiere*/
        public void Volar(int altitud)
        {
            if ((this._alturaActual + altitud) < 0)
            {
                this._alturaActual = 0;
            }
            else if ((this._alturaActual + altitud) > this._alturaMaxima)
            {
                this._alturaActual = this._alturaMaxima;
            }
            else
            {
                this._alturaActual += altitud;
            }
        }

       
    }
}