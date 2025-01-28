namespace senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123"; //   senha correta
            string senhaDigitada; // senha digitada pelo usuário
            int tentativas = 0; // contador de tentativas

            // Loop para solicitar a senha do usúario

            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas ++; // Incrementa o contador de tentativas
                //Verifica se a senha digitada é diferente da senha correta 

                if (senhaDigitada != senha && tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta!");
                    Console.WriteLine("Você ainda tem:" + (3 - tentativas) + "tentativa(s)");
                    Console.ReadKey();
                } 
                else if (senhaDigitada != senha && tentativas == 3)

                {
                    Console.WriteLine("Senha incorreta! Seu bandidinho!");
                    return; // serve para parar o loop

                }
            }while(senhaDigitada != senha);
             
            Console.Clear() ;
            Console.WriteLine("senha correta! - Tentativas:" + tentativas);
            
            
        }
    }
}
