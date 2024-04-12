using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class FolhaPag
    {
        public string? Nome { get; set; }
        public double Sal { get; set; }
        public double Hed { get; set; }
        public double Hen { get; set; }
        public double Nd { get; set; }
        public double Fal { get; set; }
        public double De { get; set; }
        public double Ref { get; set; }
        public double Val { get; set; }
        public double HoraExtra { get; set; }
        public double SalF { get; set; }
        public double SalB { get; set; }
        public double INAMPS { get; set; }
        public double Faltas { get; set; }
        public double ImpR { get; set; }
        public double DescFinal { get; set; }
        public double SalLiq { get; set; }

        public void Calc()
        {
            HoraExtra = Hed * Sal / 160 + Hen * 1.2 * Sal / 160;
            SalF = Nd * 0.05 * 1.371;
            SalB = Sal + HoraExtra + SalF;

            INAMPS = 0.08 * Sal;
            Faltas = Fal * Sal / 160;
            ImpR = 0.08 * SalB;

            DescFinal = INAMPS + Faltas + ImpR + Ref + Val + De;

            SalLiq = SalB - DescFinal;

            Console.WriteLine("O salário líquido do funcionário " + Nome + " é de R$" + SalLiq); 


        }

    }
}
