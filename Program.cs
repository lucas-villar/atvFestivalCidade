Console.Write("Nome do Fa: ");
string nomeFa = Console.ReadLine() ?? string.Empty;

Console.Write("Quantidade de Dias de Show: ");
int quantidadeDias = Convert.ToInt32(Console.ReadLine());

Console.Write("Cupom de Desconto: ");
string cupomDesconto = Console.ReadLine() ?? string.Empty;

Console.Write("Pontuacao do Clube de Fidelidade: ");
int pontuacaoFidelidade = Convert.ToInt32(Console.ReadLine());

const decimal taxaServico = 15.00m;
const decimal precoPorDia = 120.00m;

decimal custoBruto = taxaServico + (precoPorDia * quantidadeDias);

decimal desconto = cupomDesconto.Trim().Equals("ROCK10", StringComparison.OrdinalIgnoreCase)
    ? custoBruto * 0.10m
    : 0.00m;

decimal valorFinal = custoBruto - desconto;

bool acessoLoungeVip = quantidadeDias > 2 && pontuacaoFidelidade >= 500;

Console.WriteLine();
Console.WriteLine($"Fa: {nomeFa.ToUpper()}");
Console.WriteLine($"Valor Bruto: R$ {custoBruto:F2}");
Console.WriteLine($"Valor Final: R$ {valorFinal:F2}");
Console.WriteLine($"Acesso ao Lounge VIP: {acessoLoungeVip}");
