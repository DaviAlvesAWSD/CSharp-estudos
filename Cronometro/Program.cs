using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.Clear();
            Console.WriteLine("Stop watch finalizado");
            Thread.Sleep(2500);

        }

        // metodo responsavel pela iniciação e contagem do cronometro
        static void Start(int time)
        {
            //int time = 10;
            int currentTime = 0;

            // contador
            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            
            Menu();
        }

        // metodo responsavel pela chamada do menu com as opções do aplicação
        static void Menu()
        {
            Console.Clear();
            //itens do menu
            Console.WriteLine("S = Segundos ex: 10s");
            Console.WriteLine("M = Minutos ex: 10m");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");
            

            string data = Console.ReadLine().ToLower();

            // linhas 47 e 48 responsaveis por separar o caractere do número
            char type = char.Parse(data.Substring(data.Length - 1,1));
            int time = int.Parse(data.Substring(0,data.Length - 1));
            
            // multiplicador para conversão
            int multiplier = 1;

            // conversão de segundos para minutos
            if(type == 'm')
                multiplier = 60;
            
            // sair da aplicação
            if(time == 0)
                System.Environment.Exit(0);
            
            Thread.Sleep(2500);
            
            Start(time * multiplier);

        }
    }
}
