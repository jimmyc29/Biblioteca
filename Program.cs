using System;


//Clase que representa una Biblioteca
public class Biblioteca
{
    //Atributos
    public string NombreLibro { get; set; }
    public string Autor { get; set; }
    public int Edicion { get; set; }

    //Constructor de la clase Biblioteca
    public Biblioteca(string nombrelibro, string autor, int edicion)
    {
        this.NombreLibro = nombrelibro;
        this.Autor = autor;
        this.Edicion = edicion;
    }

    //Metodo para acceder a los atributos
    public string nombreLibro
    {
        get => NombreLibro;
        set => NombreLibro = value;
    }

    public string autor
    {
        get => Autor;
        set => Autor = value;
    }

    public int edicion
    {
        get => Edicion;
        set
        {
            if (value > 0)
            {
                Edicion = value;
            }
            else
            {
                throw new ArgumentException("La edición debe ser mayor a 0");
            }
        }
    }

    //Metodo para mostrar informacion de la clase
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre del Libro: {NombreLibro}, Autor: {Autor}, Edición: {Edicion}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Codigo para evaluar la clase biblioteca
        Biblioteca libro = new Biblioteca("Física Universitaria", "Young y Freedman", 1);
        libro.MostrarInformacion();
    }

}