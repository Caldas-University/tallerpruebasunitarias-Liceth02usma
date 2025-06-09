using NUnit.Framework;

[TestFixture]
public class CuentaAhorrosTests
{
    private CuentaAhorrosService _cuentaAhorrosService;

    [SetUp]
    public void Setup()
    {
        _cuentaAhorrosService = new CuentaAhorrosService();
    }

    [Test]
    public void TC1_RetiroValido()
    {
        var cuenta = new CuentaAhorros { EstaActiva = true, SaldoDisponible = 1000, LimiteRetiroDiario = 500, EstaBloqueadaPorFraude = false };
        var montoSolicitado = 100;

        var resultado = _cuentaAhorrosService.ValidarRetiro(cuenta, montoSolicitado);

        Assert.IsTrue(resultado);
    }

    [Test]
    public void TC2_SaldoBajo()
    {
        var cuenta = new CuentaAhorros { EstaActiva = true, SaldoDisponible = 50, LimiteRetiroDiario = 500, EstaBloqueadaPorFraude = false };
        var montoSolicitado = 100;

        var resultado = _cuentaAhorrosService.ValidarRetiro(cuenta, montoSolicitado);

        Assert.IsFalse(resultado);
    }

    [Test]
    public void TC3_SuperaLimite()
    {
        var cuenta = new CuentaAhorros { EstaActiva = true, SaldoDisponible = 1000, LimiteRetiroDiario = 500, EstaBloqueadaPorFraude = false };
        var montoSolicitado = 600;

        var resultado = _cuentaAhorrosService.ValidarRetiro(cuenta, montoSolicitado);

        Assert.IsFalse(resultado);
    }

    [Test]
    public void TC4_CuentaBloqueada()
    {
        var cuenta = new CuentaAhorros { EstaActiva = true, SaldoDisponible = 1000, LimiteRetiroDiario = 500, EstaBloqueadaPorFraude = true };
        var montoSolicitado = 100;

        var resultado = _cuentaAhorrosService.ValidarRetiro(cuenta, montoSolicitado);

        Assert.IsFalse(resultado);
    }

    [Test]
    public void TC5_MontoIncorrecto()
    {
        var cuenta = new CuentaAhorros { EstaActiva = true, SaldoDisponible = 1000, LimiteRetiroDiario = 500, EstaBloqueadaPorFraude = false };
        var montoSolicitado = 105;

        var resultado = _cuentaAhorrosService.ValidarRetiro(cuenta, montoSolicitado);

        Assert.IsFalse(resultado);
    }

    [Test]
    public void TC6_CuentaInactiva()
    {
        var cuenta = new CuentaAhorros { EstaActiva = false, SaldoDisponible = 1000, LimiteRetiroDiario = 500, EstaBloqueadaPorFraude = false };
        var montoSolicitado = 100;

        var resultado = _cuentaAhorrosService.ValidarRetiro(cuenta, montoSolicitado);

        Assert.IsFalse(resultado);
    }
}
