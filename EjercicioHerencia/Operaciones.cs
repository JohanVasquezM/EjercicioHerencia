using EjercicioHerencia;

namespace EjercicioHerencia
{
    public class Operaciones
    {
        public double CalcularAreaCuadrado(double lado)
        {
            return lado * lado;
        }

        public double CalcularVolumenCubo(double lado)
        {
            return lado * lado * lado;
        }

        public double CalcularLongitudCircunferencia(double radio)
        {
            return 2 * Math.PI * radio;
        }
    }
}
