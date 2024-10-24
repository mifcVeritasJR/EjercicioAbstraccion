using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class AreaTriangulo : FormulaMatematica
    {
        private double baseTriangulo;
        private double altura;
        private double area;

        public AreaTriangulo(double baseTriangulo, double altura, double area)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
            this.area = area;
        }

        public override void Calcular()
        {
            area = (baseTriangulo + altura) / 2;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El área del triángulo con base {baseTriangulo} y altura {altura} es: {area}");
        }
    }
}