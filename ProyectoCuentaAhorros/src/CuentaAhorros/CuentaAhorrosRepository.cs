using System.Collections.Generic;

public class CuentaAhorrosRepository
{
    private List<CuentaAhorros> _cuentas;

    public CuentaAhorrosRepository()
    {
        // Cargar cuentas ficticias desde un archivo JSON o base de datos (simulado)
        _cuentas = new List<CuentaAhorros>
        {
            new CuentaAhorros { CuentaId = 1, EstaActiva = true, SaldoDisponible = 1000, LimiteRetiroDiario = 500, EstaBloqueadaPorFraude = false },
            new CuentaAhorros { CuentaId = 2, EstaActiva = true, SaldoDisponible = 300, LimiteRetiroDiario = 200, EstaBloqueadaPorFraude = false },
            new CuentaAhorros { CuentaId = 3, EstaActiva = false, SaldoDisponible = 500, LimiteRetiroDiario = 500, EstaBloqueadaPorFraude = false },
            new CuentaAhorros { CuentaId = 4, EstaActiva = true, SaldoDisponible = 1500, LimiteRetiroDiario = 1000, EstaBloqueadaPorFraude = true },
            new CuentaAhorros { CuentaId = 5, EstaActiva = true, SaldoDisponible = 800, LimiteRetiroDiario = 500, EstaBloqueadaPorFraude = false }
        };
    }

    // Método para obtener todas las cuentas
    public List<CuentaAhorros> ObtenerCuentas()
    {
        return _cuentas;
    }

    // Método para obtener una cuenta por su ID
    public CuentaAhorros ObtenerCuentaPorId(int cuentaId)
    {
        return _cuentas.FirstOrDefault(c => c.CuentaId == cuentaId);
    }
}

