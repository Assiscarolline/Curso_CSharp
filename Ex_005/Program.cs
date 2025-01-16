namespace Ex_005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            Console.WriteLine("Digite a nota");

            num1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite a outra nota:");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            num4= (num1 + num2)/ 2;

            Console.WriteLine("É soma é {0}", media);

        }
    }
}
