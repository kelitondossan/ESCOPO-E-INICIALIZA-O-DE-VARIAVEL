using System;

namespace ESCOPO_E_INICIALIZAÇÃO_DE_VARIAVEL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programinha de desconto");
            double preco = double.Parse(Console.ReadLine());
            double desconta = 0.0;
            if(preco > 100)
            {
                desconta = preco * 0.1;
            }
            else if (preco < 100)
            {
                desconta = preco * 0.2;
            }
            
            Console.WriteLine( $"voce ganhou desconto de ${desconta:F2} você ira pagar  {preco - desconta:F2}\n ");
        }
    }
}
