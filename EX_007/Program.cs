namespace EX_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final, n1, n2, n3, n4;
            string resultado;

            Console.Write("digite a primeira nota do aluno: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a segunda nota do aluno: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a terceira nota do aluno: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a quartanota do aluno: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            nota_final = (n1 + n2 + n3 + n4) / 4;

            if (nota_final >= 60)
            {
                if (nota_final >= 90)
                {
                    resultado = "aprovado com louvor";
                }
                      
                else
                {
                    resultado = "aprovado";
                }
                    
                
            }
            else 
            {
                if (nota_final >= 40);
                {
                    resultado = "reprovado";
                }
            }



            Console.WriteLine("Nota do aluno: {0} - resultado : {1}.",nota_final, resultado);
        }
    }
}
