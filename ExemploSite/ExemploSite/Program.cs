namespace ExemploSite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Rapha";
            p.DataNasc = new DateTime(2007, 9, 24);
            p.Altura = 1.60f;

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);
        }
    }
}