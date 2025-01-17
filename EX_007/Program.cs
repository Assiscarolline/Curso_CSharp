namespace EX_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final = 40;
            string resultado;

            if (nota_final >= 60)
            {
                resultado = "aprovado";
            }
            else if (nota_final >= 40)
            {

                resultado = "recuperação";
            }

            else 

            {
                resultado = "reprovado";
            }



            Console.WriteLine("O aluno foi {0}.", resultado);
        }
    }
}
