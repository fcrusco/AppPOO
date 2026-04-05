
using AppPOOReview.Interface;

namespace AppPOOReview.Model;

public abstract class FreteBase : IFreteService
{
    // Encapsulamento
    // Todo frete terá um valor base e todo frete saberá calcular seu custo,
    // mas eu não sei calcular o custo sozinha; cada tipo de frete deve
    // implementar sua própria regra.
    // Encapsulamento com foco em Reuso e Segurança 
    // Protected e Somente Leitura
    protected decimal ValorBase { get; } = 10;

    public abstract decimal Calcular(decimal peso);
}
