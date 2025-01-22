namespace Ex_0011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, salario_final;

            Console.WriteLine("Digite o seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario > 2500)
            {
                salario_final = salario * 0.05 + salario;
                Console.WriteLine("O salário final é {0}.", salario_final);
            }
            else if (salario > 1250)
            {
                salario_final = salario * 0.10 + salario;
                Console.WriteLine("O salário final é {0}.", salario_final); 
             
            }
            else 
            {
                salario_final = salario * 0.15 + salario;
                Console.WriteLine("O salário final é {0}.", salario_final);
            }


               

        }
    }
}
