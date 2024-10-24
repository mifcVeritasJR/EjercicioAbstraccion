using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class ConversionMetrosKilometros : FormulaMatematica
    {
        private double metros;
        private double kilometros;

        public ConversionMetrosKilometros(double metros)
        {
            this.metros = metros;
        }

        public override void Calcular()
        {
            kilometros = metros / 1000;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{metros} metros son equivalentes a {kilometros} kilómetros.");
        }
    }