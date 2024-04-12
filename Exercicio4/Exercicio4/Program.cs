namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FolhaPag folhapag = new FolhaPag();

            Console.WriteLine("Digite o nome do funcionário");
            folhapag.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salário");
            folhapag.Sal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite as horas extras diurnas");
            folhapag.Hed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite as horas extras noturnas");
            folhapag.Hen = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o número de dependentes");
            folhapag.Nd = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o número de faltas em horas");
            folhapag.Fal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o número de descontos eventuais");
            folhapag.De = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o número de gastos com refeições feitas na empresa");
            folhapag.Ref = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o número vales retirados durante o mês");
            folhapag.Val = Convert.ToDouble(Console.ReadLine());

            folhapag.Calc();
        }
    }
}