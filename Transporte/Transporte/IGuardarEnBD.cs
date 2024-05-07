using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public interface IGuardarEnBD
    {
      
        public void guardarEnBD()
        {
            TransporteRepository repository = new TransporteRepository();
            repository.guardar(this);
        }
    }


}
