

using Moeda;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

double cotacao;
double compra;
void CotacaoAtual()
{
    Console.Write("Qual é a cotacao do dolar? ");
    cotacao = double.Parse(Console.ReadLine());

 }


void Pagamento()
{
    Console.Write("Quantos dólares voce vai comprar ? ");
    compra = double.Parse(Console.ReadLine()); 

     
}
CotacaoAtual();
Pagamento();
Console.Write($"Valor a ser pago em reais = {ConversorMoeda.Conversor(cotacao, compra):c}");
ConversorMoeda.Conversor(cotacao, compra);
