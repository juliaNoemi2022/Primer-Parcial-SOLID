﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class TransporteRepository
    {
        public void guardar(ITransporte transporte)
        {
            //Este método se encarga de guardar el estado actual del Tren en una base de datos
            //La implementación del código interno de este método NO es relevante para la resolución del ejercicio
        }

        internal void guardar(IGuardarEnBD guardarEnBD)
        {
            throw new NotImplementedException();
        }
    }
}