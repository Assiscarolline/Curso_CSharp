namespace Calculo_aréa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================");
            Console.WriteLine("Controle de terrenos");
            Console.WriteLine("====================");

            Console.Write("Digite a Largura do terreno(m)");
            double largura =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o comprimento do terreno(m)");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            areaterreno(largura, comprimento);
        }
        static void areaterreno(double l, double c)
        {
            double a = l * c;
            Console.WriteLine($"A área do terreno de {l}m x {c}m é de {a:F2}m².");
        }
           
    }

}
