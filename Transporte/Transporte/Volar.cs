using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Volar
    {
    
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
