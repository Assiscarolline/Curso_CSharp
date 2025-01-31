namespace Area_do_triângulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************");
            Console.WriteLine("Digite a aréa do triagulo:");
            Console.WriteLine("**************************");

            Console.Write("Digite a base: ");
            double baseA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Area(baseA, altura);
        }
        static void Area(double baseA, double altura )
        {
            double A = altura * baseA / 2;
            Console.WriteLine($"A aréa do triângulo {altura} x {baseA} = {A}");
        }

        
    }
}
