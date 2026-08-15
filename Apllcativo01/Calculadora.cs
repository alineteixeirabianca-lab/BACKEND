
namespace Apllcativo01
{
    internal static class Calculadora
    {

        //membros
        public const double pi = 3.1415;


        //metodos

        public static double Circunferencia(double raio)
        {
            return 2 * pi * raio;
        }

        public static double Volume(double raio)
        {
            return (4 * pi * Math.Pow(raio, 3) / 3);
        }

        public static void PI()
        {
            Console.WriteLine(pi);
        }
    }

}
