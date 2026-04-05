// Importa o contrato (Interface) que define as regras do serviço de frete
using AppPOOReview.Interface;
// Importa as classes de modelo (Expresso e Econômico) que contêm as fórmulas de cálculo
using AppPOOReview.Model;
// Importa a classe de serviço que orquestra a exibição dos cálculos
using AppPOOReview.Service;

// Variável de controle (flag) para manter o loop do menu ativo
bool continuar = true;

// Estrutura de repetição para permitir múltiplos cálculos sem fechar o programa
while (continuar)
{
    // Limpa o console para manter a interface organizada a cada novo cálculo
    Console.Clear();
    // Exibe o título principal do sistema
    Console.WriteLine("--- Comparativo de Fretes Logísticos ---");
    // Orienta o usuário sobre as opções de operação ou saída
    Console.WriteLine("Digite o peso para calcular ou 'S' para sair.");
    // Solicita a entrada do peso de forma visual
    Console.Write("\nInforme o peso da carga (kg): ");

    // Captura o que o usuário digitou e armazena em uma variável de texto
    string entrada = Console.ReadLine();

    // Verifica se o usuário digitou 's' (em maiúsculo ou minúsculo) para encerrar
    if (entrada.ToLower() == "s")
    {
        // Altera a flag para falso para interromper a próxima verificação do while
        continuar = false;
        // Sai imediatamente do laço de repetição atual
        break;
    }

    // Tenta converter o texto da entrada em um número decimal
    if (decimal.TryParse(entrada, out decimal peso))
    {
        Console.WriteLine("\n--- Resultados do Orçamento ---");

        // 1. INJEÇÃO DE DEPENDÊNCIA - MODALIDADE EXPRESSA
        // Aplica polimorfismo: Variável interface recebendo um objeto concreto (Expresso)
        IFreteService freteExpresso = new FreteExpresso();

        // Injeta a implementação 'Expresso' no construtor da classe de serviço
        var appExpresso = new CalculadoraLogistica(freteExpresso);

        // Exibe o rótulo da modalidade
        Console.Write("[MODALIDADE EXPRESSA] ");

        // Chama o método que executa o cálculo e imprime o valor formatado
        appExpresso.ExibirOrcamento(peso);


        // 2. INJEÇÃO DE DEPENDÊNCIA - MODALIDADE ECONÔMICA
        // Cria a instância da estratégia econômica respeitando o contrato da interface
        IFreteService freteEconomico = new FreteEconomico();

        // Reutiliza o serviço 'CalculadoraLogistica' injetando agora a estratégia econômica
        var appEconomico = new CalculadoraLogistica(freteEconomico);
        // Exibe o rótulo da modalidade
        Console.Write("[MODALIDADE ECONÔMICA] ");
        // Executa a lógica de negócio para a segunda modalidade
        appEconomico.ExibirOrcamento(peso);

        Console.WriteLine("-------------------------------");
    }
    // Caso o TryParse falhe (usuário digitou letras ou caracteres inválidos)
    else
    {
        // Exibe mensagem de erro para o usuário
        Console.WriteLine("Peso inválido! Por favor, utilize números.");
    }

    // Solicita uma interação antes de limpar a tela e voltar ao início do loop
    Console.WriteLine("\nPressione qualquer tecla para realizar um novo cálculo...");

    // Pausa a execução para que o usuário consiga ler os resultados na tela
    Console.ReadKey();
}

// Mensagem final exibida apenas quando o usuário decide sair do programa
Console.WriteLine("Sistema encerrado. Obrigado por utilizar nossos serviços!");