namespace Métodos
{
    internal class Program
    {
        static void Main(string[] args) // main é o método principal
        {
            saudacao("Carolline");  //Olá Carol, seja bem vinda
            soma(10, 20);
        }

        static void saudacao (string nome) // saudacao é um método
        {
            Console.WriteLine($"Olá {nome}, seja bem-vinda!");
        }
        static void soma(int a, int b)
        {
            int resultado = a + b; 
            Console.WriteLine( $"a SOMA DE {a} + {b} É IGUAL A {resultado}");
            Console.WriteLine("A soma de {0}+ {1} é igual a {2}.", a, b, resultado);
            Console.WriteLine("A soma de "+ a +" + " + b + " é igual a " + resultado + ".");

            // ambos são o mesmo resultado só mudam a formula
        }

    }
}
