namespace Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho","Julho",
                 "Agosto","Setembro", "Outubro", "Novembro"};
             int[] dias = { 31, 28, 31, 30, 31, 31, 30, 31, 30, 31, 30, 31 };
             for (int i = 0; i < meses.Length; i++)
             {
                 Console.WriteLine("O mês de " + meses[i] + " tem " + dias[i] + " dias ");
             }
            String[] semana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado" };

            foreach (string dia in semana) //acha o elemento
            {
                Console.WriteLine(dia);
            }*/

            int[] numero = { 10, 45, 22, 59, 6, -84, -2, 91, -23 };
            Console.WriteLine(numero.First()); // descobrir o maior nú
            Console.WriteLine(numero.Last()); //descobrir o menor num
            Console.WriteLine(); 
            Console.WriteLine(numero.Max()); // descobre o maior
            Console.WriteLine(numero.Min()); // descobre o menor
            Console.WriteLine(numero.Average());
            
         

        }
    }
}
