using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Clear();

            Numbers number = new Numbers(); 

            string option;

            Console.Write("Insira o primeiro digite: ");
            number.Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o segundo digito: ");
            number.Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\t\t\tMenu");
            Console.WriteLine("\t\t1 -\t\tsoma \n \t\t2 -\t\tsubtração \n \t\t3 - \t\tmultiplicação \n \t\t4 - \t\tdivisão");
            option = Console.ReadLine();
            Console.WriteLine(option);
            
            switch(option)
            {
                case "1": 
                    Console.Clear();
                    number.Result = (number.Number1 + number.Number2); 
                    Console.WriteLine("A soma entre " + number.Number1 + " e " + number.Number2 + " é: " + number.Result);
                break;
                case "2": 
                    Console.Clear();
                    number.Result = (number.Number1 - number.Number2); 
                    Console.WriteLine("A subtração entre " + number.Number1 + " e " + number.Number2 + " é: " + number.Result);
                break;
                case "3": 
                    Console.Clear();
                    number.Result = (number.Number1 * number.Number2); 
                    Console.WriteLine("A multiplicação entre " + number.Number1 + " e " + number.Number2 + " é: " + number.Result);
                break;
                case "4": 
                    Console.Clear();
                    number.Result = (number.Number1 / number.Number2); 
                    Console.WriteLine("A divisão entre" + number.Number1 + " e " + number.Number2 + " é: " + number.Result);
                break;
                default: Console.Clear(); Console.WriteLine("Error: option ivalid"); break;
            };

            
        }
        
    }

    struct Numbers
    {
        public int Number1;
        public int Number2;
        public int Result;
    }
}
