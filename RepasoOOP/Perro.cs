using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoOOP
{
static class Algebra
{
    public static int Sumar(double a, double b);
    public static int Restar(double a, double b);
    public static int Multiplicar(double a, double b);
    public static int Dividir(double a, double b);
}

class Mamifero
{
    int nroPatas = 2;
    int peso;
    string ambiente;
    public bool alas;
    public bool dejaHuevos;
    static string planeta = "Tierra";

    public static string ObtenerNombrePlaneta()
    {
        return planeta;
    }
}

class Perro : Mamifero
{
    string nombre;
    string color;
    double tamaño;
    bool cola;

    //propiedad explícita
    public string Nombre
    {
        get { return this.nombre; }
        set
        {
            if (value == "")
                this.nombre = "sin nombre";
            else
                this.nombre = value;
        }
    }
    //propiedad automática
    public string Raza { get; set; }
}
        //constructor vacío
        public Perro()
        {
            
        }

        //constructor con argumentos
        public Perro(string nombre, string raza, bool cola)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.cola = cola;
        }


        public void Ladrar()
        {
            //this
        }

        public void Crecer(double nuevoTamaño)
        {
            tamaño = nuevoTamaño;
            //equivalente
            this.tamaño = nuevoTamaño;
        }
    }
}
