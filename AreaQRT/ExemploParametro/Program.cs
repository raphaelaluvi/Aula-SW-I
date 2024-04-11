namespace ExemploParametro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //chama os objetos
            Area area = new Area();

            Console.WriteLine("Digite a base: ");
            area.Base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a base: ");
            area.Altura= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha: \n1 - Quadrado \n2 - Retângulo \n3 - Triângulo");
            int opcao = Convert.ToInt32(Console.ReadLine());
            area.Escolha(opcao);
            


        }
    }
}