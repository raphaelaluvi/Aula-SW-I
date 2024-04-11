namespace contaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao banco da ETEC MCM!!");
            //Instanciar a classe Conta e criar um objeto
            Conta conta = new Conta();

            //CONSULTA SALDO
            Console.WriteLine("CONSULTADO SALDO:");
            conta.consulta_saldo();

            //DEPOSITO
            Console.WriteLine("DEPÓSITO DE 1000.35:");
            conta.depositar(1000.35);
            Console.WriteLine("CONSULTADO SALDO");
            conta.consulta_saldo(); //saldo foi atualizado só chamar o consulta_saldo

            //SAQUE
            //Console.WriteLine("SAQUE DE 500:");
            //conta.sacar(500);
            //Console.WriteLine("CONSULTADO SALDO:");
            //conta.consulta_saldo(); //saldo foi atualizado só chamar o consulta_saldo

            //SAQUE PARA SALDO INSUFICIENTE
            //Console.WriteLine("SAQUE DE 1000:");
            //conta.sacar(1000);

            Console.WriteLine("PASSANDO VALOR LIMITE:");
            conta.ajusta_limite(1000);
            conta.consulta_saldo();

            conta.sacar(2000);
            conta.consulta_saldo();


        }
    }
}