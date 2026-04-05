
namespace AppPOOReview.Model;

public class FreteExpresso : FreteBase
{
    // Polimorfismo: Implementação específica para Frete Expresso
    public override decimal Calcular(decimal peso) => ValorBase + (peso * 2);
}
