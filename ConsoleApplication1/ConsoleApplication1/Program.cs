using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Persona p = new Persona();
            p.setNombre("juan");
            p.setEdad(18);
            p.presentar();
            Console.ReadLine();
        }
    }
}
