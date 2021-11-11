using System;

namespace aulaGitClone_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1=0, n2=0, res;
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Minha Super Calculadora\n\n");
                
                Console.WriteLine("Selecione a opção:\n\n" +
                    "1 - Adição\n" +
                    "2 - Subtração\n" +
                    "3 - Multiplicação\n" +
                    "4 - Divisão\n" +
                    "5 - Sair do Sistema");
                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao != 5)
                {
                    Console.WriteLine("Digite o primeiro número:");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    n2 = Convert.ToDouble(Console.ReadLine());
                }
                
                switch (opcao)
                {
                    case 1:
                        res = n1 + n2;
                        Console.WriteLine("Soma {0}", res.ToString());
                        break;
                    case 2:
                        res = n1 - n2;
                        Console.WriteLine("Subração {0}", res.ToString());
                        break;
                    case 3:
                        res = n1 * n2;
                        Console.WriteLine("Multiplicação {0}", res.ToString());
                        break;
                    case 4:
                        if (n2 != 0)
                        {
                            res = n1 - n2;
                            Console.WriteLine("Subração {0}", res.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Impossível dividir por zero!");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Obrigado por utilizar nossos produtos");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            } while (opcao != 5);
        }
    }
}
