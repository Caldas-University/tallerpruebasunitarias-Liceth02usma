using System;

namespace ProyectoCuentaAhorrosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una cuenta de ejemplo
            var cuenta = new CuentaAhorros
            {
                CuentaId = 1,
                EstaActiva = true,
                SaldoDisponible = 1000,
                LimiteRetiroDiario = 500,
                EstaBloqueadaPorFraude = false
            };

            // Crear una instancia del servicio para validar el retiro
            var servicioCuenta = new CuentaAhorrosService();

            // Monto solicitado para el retiro
            var montoSolicitado = 200;

            // Verificar si el retiro es válido
            bool puedeRetirar = servicioCuenta.ValidarRetiro(cuenta, montoSolicitado);

            // Mostrar el resultado
            if (puedeRetirar)
            {
                Console.WriteLine("Retiro aprobado.");
            }
            else
            {
                Console.WriteLine("Retiro no aprobado.");
            }
        }
    }
}
