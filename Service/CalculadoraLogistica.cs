
using AppPOOReview.Interface;
using AppPOOReview.Util;

namespace AppPOOReview.Service;

public class CalculadoraLogistica
{
    private IFreteService _freteService;

    // Injeção de Dependência via Construtor
    public CalculadoraLogistica(IFreteService freteService)
    {
        _freteService = freteService;
    }

    public void ExibirOrcamento(decimal peso)
    {
        decimal total = _freteService.Calcular(peso);
        Console.WriteLine($"O custo total do frete para {peso}kg é: {FormataMoeda.Formatar(total)}");
    }
}
