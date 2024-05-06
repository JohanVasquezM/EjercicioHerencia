using EjercicioHerencia;

namespace EjercicioHerencia
{
    public class Calculadora : Operaciones
    {
        public void Imprimir()
        {
            double lado = 5.0;
            double radio = 3.0;

            Console.WriteLine("Área del cuadrado: " + CalcularAreaCuadrado(lado));
            Console.WriteLine("Volumen del cubo: " + CalcularVolumenCubo(lado));
            Console.WriteLine("Longitud de la circunferencia: " + CalcularLongitudCircunferencia(radio));
        }
    }
}
