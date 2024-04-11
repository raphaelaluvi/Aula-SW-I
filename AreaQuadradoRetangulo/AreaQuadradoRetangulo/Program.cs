namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULO DAS AREAS (QUADRADO/RETANGULO)!");
            Area area= new Area();
            Console.WriteLine("Digite o valor da base: ");
            area.Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura: ");
            area.Altura = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Area: " + area.Calcular());
            Console.WriteLine("Area: " + area.Calcular2());

            area.MostraDetalhes();
        }
    }
}