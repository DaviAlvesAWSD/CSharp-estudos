using System;
using System.IO;
using System.Threading;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");
            
            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                
                default: Menu();break;
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo");
            string text = " ";

            var path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
                text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine(" ");
            Console.ReadLine();
            Menu();
        }

        static void Edit(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo");
            Console.WriteLine("-----------------");
            string text = "";

            do{
                text += Console.ReadLine();
                text += Environment.NewLine;
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Clear();
            Save(text);            
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");

            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
