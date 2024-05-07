using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ITransporte
{
    void Acelerar(int velocidad);
    void Desacelerar(int velocidad);
    void Volar(int altitud);
    void guardarEnBD();
}

public class Tren : ITransporte
{
    public int _velocidadActual;
    public int _velocidadMaxima;

    public Tren(int velocidadActual, int velocidadMaxima)
    {
        this._velocidadActual = velocidadActual;
        this._velocidadMaxima = velocidadMaxima;
    }

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

    public void Volar(int altitud)
    {
        return;
    }

    public void guardarEnBD()
    {
        TransporteRepository repository = new TransporteRepository();
        repository.guardar(this);
    }
}

public class Avion : ITransporte
{
    public int _velocidadActual;
    public int _velocidadMaxima;
    public int _alturaActual;
    public int _alturaMaxima;

    public Avion(int velocidadActual, int velocidadMaxima, int alturaActual, int alturaMaxima)
    {
        this._velocidadActual = velocidadActual;
        this._velocidadMaxima = velocidadMaxima;
        this._alturaActual = alturaActual;
        this._alturaMaxima = alturaMaxima;
    }
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

    public void guardarEnBD()
    {
        TransporteRepository repository = new TransporteRepository();
        repository.guardar(this);
    }
}

public class TransporteRepository
{
    public void guardar(ITransporte transporte)
    {
        //Este método se encarga de guardar el estado actual del Tren en una base de datos
        //La implementación del código interno de este método NO es relevante para la resolución del ejercicio
    }
}
