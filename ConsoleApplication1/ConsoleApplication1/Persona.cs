using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    /// <summary>
    /// Clase que describe una persona
    /// </summary>
    class Persona
    {
        private String nombre;
        private int edad;

        public Persona ()
        {
            this.nombre = "";
            this.edad = 0;

        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public int getEdad()
        {
            return this.edad;
        }

        public void presentar()
        {
            Console.WriteLine("Hola soy " + this.nombre + " y tengo " + this.edad + " años");
            
        }
    }
}
