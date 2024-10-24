using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion

public class VolumenEsfera : FormulaMatematica
{
    private double radio;
    private double volumen;

    public VolumenEsfera(double radio)
    {
        this.radio = radio;
    }

    public override void Calcular()
    {
        volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
    }

    public override void Imprimir()
    {
        Console.WriteLine($"El volumen de la esfera con radio {radio} es: {volumen}");
    }
}