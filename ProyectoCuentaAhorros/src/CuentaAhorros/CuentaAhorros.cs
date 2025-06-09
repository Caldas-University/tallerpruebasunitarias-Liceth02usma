public class CuentaAhorros
{
    public int CuentaId { get; set; } // Identificador único de la cuenta
    public bool EstaActiva { get; set; } // Estado de la cuenta (activa/inactiva)
    public decimal SaldoDisponible { get; set; } // Saldo disponible en la cuenta
    public decimal LimiteRetiroDiario { get; set; } // Límite de retiro diario
    public bool EstaBloqueadaPorFraude { get; set; } // Indicador de si la cuenta está bloqueada por fraude
}
