using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class AlbumDeFotos
    {
        public int NTotalDePag { get; set; }
        public int NTotalDeFt { get; set; }
        public int NumDeFt { get; set; }

       

        public void Album() 
        {
            Console.WriteLine("Digite o número de páginas do seu álbum");
            NTotalDePag = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número de fotos que você deseja colocar");
            NumDeFt = Convert.ToInt32(Console.ReadLine());

            NTotalDeFt = NTotalDePag * 2;

            if(NTotalDeFt < NumDeFt)
            {
                Console.WriteLine("Você não pode colocar " + NumDeFt + ", o máximo é " + NTotalDeFt + " fotos.");
            }
            else
            {
                Console.WriteLine("Você pode colocar suas fotos.");
            }
        }

        

    }
}
