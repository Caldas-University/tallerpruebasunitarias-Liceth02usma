public class CuentaAhorrosService
{
    // Método que valida si se puede realizar un retiro de la cuenta de ahorros
    public bool ValidarRetiro(CuentaAhorros cuenta, decimal montoSolicitado)
    {
        // Verificar si la cuenta está activa
        if (!cuenta.EstaActiva) return false;

        // Verificar si el saldo disponible es suficiente
        if (cuenta.SaldoDisponible < montoSolicitado) return false;

        // Verificar si el monto solicitado no excede el límite de retiro diario
        if (montoSolicitado > cuenta.LimiteRetiroDiario) return false;

        // Verificar si la cuenta está bloqueada por fraude
        if (cuenta.EstaBloqueadaPorFraude) return false;

        // Verificar si el monto solicitado es múltiplo de 10
        if (montoSolicitado % 10 != 0) return false;

        // Si todas las validaciones pasaron, el retiro es válido
        return true;
    }
}