
namespace AppPOOReview.Model;

public class FreteEconomico : FreteBase
{
    // Polimorfismo: Implementação específica para Frete Economico
    public override decimal Calcular(decimal peso) => ValorBase + (peso * 1.1m);
}
