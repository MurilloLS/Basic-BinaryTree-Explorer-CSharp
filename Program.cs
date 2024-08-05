using DayFive.TreeContext;

namespace DayFive;

static class Program
{
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Inserir valor na árvore");
            Console.WriteLine("2. Buscar valor na árvore");
            Console.WriteLine("3. Exibir árvore");
            Console.WriteLine("4. Sair");
            Console.Write("Opção: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine();
                    Console.Write("Digite um valor para inserir: ");
                    int valueToInsert;
                    if (int.TryParse(Console.ReadLine(), out valueToInsert))
                    {
                        tree.Insert(valueToInsert);
                        Console.WriteLine($"Valor {valueToInsert} inserido.");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida! Tente novamente.");
                    }
                    break;

                case "2":
                    Console.WriteLine();
                    Console.Write("Digite um valor para buscar: ");
                    int valueToSearch;
                    if (int.TryParse(Console.ReadLine(), out valueToSearch))
                    {
                        bool found = tree.Search(valueToSearch);
                        if (found)
                        {
                            Console.WriteLine($"Valor {valueToSearch} encontrado na árvore.");
                        }
                        else
                        {
                            Console.WriteLine($"Valor {valueToSearch} não encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida! Tente novamente.");
                    }
                    break;

                case "3":
                    Console.WriteLine();
                    Console.WriteLine("Estrutura da Árvore:");
                    tree.PrintTree();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
