
namespace Moeda
{
    internal static class ConversorMoeda
    {
        static double iof = 0.06;
        static double pagamento;



        public static double Conversor(double c, double d)
        {
            pagamento = c * d + (c * d * iof);
            return pagamento;

        }
    }
}
