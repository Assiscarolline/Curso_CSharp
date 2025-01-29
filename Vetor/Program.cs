namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int[] num = new int[5]; //vetor principal

              num[0] = 10;
              num[1] = 20;
              num[2] = 30;
              num[3] = 40;
              num[4] = 50; // forma de criar vetores na mesma linha.
              //num[5] = 60;ERRO, passou dos limites do vetor só tem 4 posições.

              Console.WriteLine(num[2]);

              int[] n = new int[5] { 60, 70, 80, 90, 100 }; // forma de criar vetores na mesma linha.

              Console.WriteLine(n[2]);

              int[] numero = { 65, 25, 84, 76, 12, 8 }; // forma de criara vetores sem limites de casas
              Console.WriteLine(numero[23]);


            Random random = new Random(); // 

              int[] vetor = new int[10];
              for (int i = 0; i < 10; i++)
              {
                  vetor [i] = random.Next( 1, 100); // formula para números aleátorios inteiros
                  Console.WriteLine(vetor [i]);
              }
              Console.WriteLine();

              double[] reais = new double[10];

              for (int i = 0; i < 10; i++)
              {
                  reais[i] = random.NextDouble()* 10000; //número aleátorios entre 0 e 1, para ser maior precisa multiplicar *
                  Console.WriteLine(reais[i].ToString("P2")); // O toString serve para formatar o número
              } */

            string[] nomes = { "Maria", "João", "Carlos", "Pedro", "Ana", "José" }; 
            for (int i = 0; i < nomes.Length; i++) //O Length ele funciona como o leitor automático
            {  
                if(i< nomes.Length - 1)
                {
                    Console.Write(nomes[i] + ",");
                }
                else
                {
                    Console.WriteLine(nomes[i]+ ".");
                }
                
            }






        }
    }
}
