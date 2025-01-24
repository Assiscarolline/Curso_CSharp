namespace ex_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final;

            Console.Write("Digite um número, ");
            Console.Write("para saber a tabuada:");

            final = Convert.ToInt32(Console.ReadLine());

             for (int i =1; i <= 10; i++)
             {
             
                
                {
                    Console.WriteLine("{0}x {1} = {2}", final, i, final * i);
                }

                
             }



            
        }
    
}   }
