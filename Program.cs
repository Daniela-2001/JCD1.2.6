namespace JCD1._2._6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o código de seleção (Md#ID#): ");
            string codigoSelecao = Console.ReadLine();

            string[] partesCodigo = codigoSelecao.Split('#');

            if (partesCodigo.Length == 3 && partesCodigo[0].Equals("Md", StringComparison.OrdinalIgnoreCase))
            {
                int idSelecionado;
                if (int.TryParse(partesCodigo[2], out idSelecionado))
                {
                    ExecuteAplicacao(idSelecionado);
                }
                else
                {
                    Console.WriteLine("ID inválido.");
                }
            }
            else
            {
                Console.WriteLine("Código de seleção inválido.");
            }
        }

        static void ExecuteAplicacao(int id)
        {
            switch (id)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                default:
                    Console.WriteLine("ID não reconhecido.");
                    break;
            }
        }

        static void Exercicio1()
        {
            Console.WriteLine("Executando Exercício 1...");
            // Código para o Exercício 1
        }

        static void Exercicio2()
        {
            Console.WriteLine("Executando Exercício 2...");
            // Código para o Exercício 2
        }

        static void Exercicio3()
        {
            Console.WriteLine("Executando Exercício 3...");
            // Código para o Exercício 3
        }

        static void Exercicio4()
        {
            Console.WriteLine("Executando Exercício 4...");
            // Código para o Exercício 4
        }

        static void Exercicio5()
        {
            Console.WriteLine("Executando Exercício 5...");
            // Código para o Exercício 5
        }
    }
    }
