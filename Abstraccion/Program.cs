using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAbstraccion
{
    // Clase abstracta
    public abstract class Figura
    {
        // Método abstracto: debe ser implementado por las clases derivadas
        public abstract double CalcularArea();

        // Método no abstracto: tiene implementación común para todas las clases derivadas
        public void MostrarInfo()
        {
            Console.WriteLine("Soy una figura geométrica.");
        }
    }

    // Clase derivada que hereda de Figura
    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        // Implementación del método abstracto
        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }

    // Otra clase derivada que hereda de Figura
    public class Rectangulo : Figura
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        // Implementación del método abstracto
        public override double CalcularArea()
        {
            return Ancho * Alto;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de Circulo y Rectangulo
            Figura miCirculo = new Circulo(5);
            Figura miRectangulo = new Rectangulo(4, 6);

            // Mostrar información y calcular áreas
            miCirculo.MostrarInfo();
            Console.WriteLine($"Área del círculo: {miCirculo.CalcularArea()}");

            miRectangulo.MostrarInfo();
            Console.WriteLine($"Área del rectángulo: {miRectangulo.CalcularArea()}");
        }
    }
}
