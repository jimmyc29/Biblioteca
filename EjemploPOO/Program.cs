// EJEMPLO DE COMO CREAR UNA CLASE EN POO
using System;
using System.IO.Pipes;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualBasic;

// CLASE QUE REPRESENTA UN VEHICULO

public class VEHICULO
{
    //Atributos de la clase

    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }

    //Constructor de la clase Vehiculo
    public VEHICULO(string marca, string modelo, int anio)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Anio = anio;
    }

    //Metodo para acceder a los atributos
    public string marca
    {
        get => Marca;
        set => Marca = value;
    }

    public string modelo
    {
        get => Modelo;
        set => Modelo = value;
    }

    public int anio
    {
        get => Anio;
        set
        {
            if (value > 1885)
            {
                Anio = value;
            }
            else
            {
                throw new ArgumentException("El año debe ser mayor a 1885");
            }
        }
    }

    //Metodo para mostrar informacion de la clase
    public void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Anio: {Anio}");

    }
}

class Program
{
    static void Main(string[] args)
    {
        //Codigo para evaluar mi vehiculo segun el año
        var miAuto = new VEHICULO("Toyota", "Corolla", 2020);
        miAuto.MostrarInformacion();
        miAuto.anio = 2022;
        miAuto.MostrarInformacion();
    }
}
