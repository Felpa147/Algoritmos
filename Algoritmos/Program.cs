namespace Algoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora de àrea e perímetro do seu terreno");

            Console.WriteLine("Por favor, coloque a largura da sua área");
            int largura = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, coloque a altura da sua área");
            int altura = int.Parse(Console.ReadLine());

            int perimetro =largura * 2 + altura * 2;
            int area = largura * altura;
       
            Console.WriteLine("Digite 1 para calcular a área\n" + "Digite 2 para calcular o perímetro");
         
            int resposta = int.Parse(Console.ReadLine());
            if(resposta == 1)
            {
                Console.WriteLine(area);
            }
           else if(resposta == 2)
                {
                Console.WriteLine(perimetro);
                }
            else
            {
              Console.WriteLine("Por favor, escolha entre a opção 1 e 2");
            };
          
            
           

  


        }
    }
}