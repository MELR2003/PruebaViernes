using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaViernes
{
    public partial class Automovil
    {
        public void Conducir(int distancia)
        {
            if (PuedeConducir(distancia))
            {
                double combustibleConsumido = distancia / RendimientoCombustible;
                NivelCombustible -= combustibleConsumido;
                Console.WriteLine($"El automóvil recorrió {distancia} km. Combustible consumido: {combustibleConsumido} galones.");
            }
            else
            {
                Console.WriteLine("No hay suficiente combustible para recorrer la distancia especificada.");
            }
        }


        public void ReabastecerCombustible(double cantidad)
        {
            if (NivelCombustible + cantidad <= CapacidadTanqueCombustible)
            {
                NivelCombustible += cantidad;
                Console.WriteLine($"Se reabastecieron {cantidad} galones de combustible.");
            }
            else
            {
                Console.WriteLine("No se puede reabastecer más combustible. El tanque está lleno.");
            }
        }


        public bool PuedeConducir(int distancia)
        {
            double combustibleNecesario = distancia / RendimientoCombustible;
            return combustibleNecesario <= NivelCombustible;
        }
    }
}