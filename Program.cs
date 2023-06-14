using System.Drawing;

internal class Program
{
    //funções 

    //===============================================================================================================================

    //Array
    static string[] nomesMotores = new string[15];
    static double[] gastosMotores = new double[15];
    static int quantidadeMotores = 0;



    //===============================================================================================================================

    //função que lança o gasto de cada motor
    static void lancargastos()
    {

        double valor;

        Console.Clear();
        Console.WriteLine("Lançar Gastos: ");
       
        
       // Verificar se o limite máximo de motores foi atingido

        if (quantidadeMotores >= 15)
        {
            Console.WriteLine("Limite máximo de motores atingido.");
            return;
           
        }

        Console.Write("Digite o nome do motor: ");
        string motor = Console.ReadLine(); // Ler o nome do motor digitado pelo usuário
        

        do
        {

            Console.Write("Digite o valor do gasto: ");
            

            valor = double.Parse(Console.ReadLine()); //armazena na variavel valor


            if (valor >= 0)
            {
                Console.Clear();
                Console.WriteLine("Gasto lançado com sucesso!");
                // Ler e validar o valor do gasto digitado pelo usuário

                nomesMotores[quantidadeMotores] = motor;
                gastosMotores[quantidadeMotores] = valor;
                quantidadeMotores++;
                // Armazenar o nome do motor e o valor do gasto no array
            }

            else
            {

                Console.Clear();
                Console.WriteLine("Valor inválido. Digite novamente: ");

                

              
            }



            

        } while (valor <= 0);

    }

        //===============================================================================================================================

        //função que gera relatorio de gastos

        static void mostrargastos()
    {
        Console.Clear();
        Console.WriteLine(" Gastos: ");

        // Verificar se não há motores cadastrados
        if (quantidadeMotores == 0)
        {
            Console.WriteLine("Não Ha motores cadastrados.");
            return;

        }

        Console.WriteLine("Gastos:");

        for(int i = 0; i < quantidadeMotores; i++)
        {
            Console.WriteLine($"{ nomesMotores[i]}:R$ {gastosMotores[i]}");
        }
        //exibe gasto de cada motor

    }
    //===============================================================================================================================
    
    //função motor que mais gastou

    static void motorquemaisgastou()                          
    {
        Console.Clear();
        Console.WriteLine(" Motor com maior gasto: ");

        // Verificar se não há motores cadastrados
        if (quantidadeMotores == 0)
        {
            Console.WriteLine("Não Ha motores cadastrados.");
            return;

        }



    }
    //===============================================================================================================================
    
    
    //Função verifica se opção e valida 0 , 1, 2, 3

    static bool ValidarOpcao(string opcao)
    {
        return opcao == "0" || opcao == "1" || opcao == "2" || opcao == "3";   


    }
    //===============================================================================================================================


    //Função MAIN
    private static void Main(string[] args)
    {
       bool sair= false;
       string opcao;

        do //do inicial 1
        {
            Console.WriteLine("Escolha a opção a baixo");
            Console.WriteLine("- 0 Sair");
            Console.WriteLine("- 1 Lançar gasto");
            Console.WriteLine("- 2 mostrar gastos");
            Console.WriteLine("- 3 Motor que mais gastou");

            

            do //do inicial 2
            {
                opcao = Console.ReadLine();

            } while (!ValidarOpcao(opcao));// while final 2

            if (opcao == "0")
            {

               sair = true; //sair do programa
            }
            if (opcao == "1")
            {
                lancargastos(); //chama função para lancar gastos
            }

            if (opcao == "2")
            {
                mostrargastos();

            }

            if (opcao == "3")
            {
                motorquemaisgastou();
            }
            Console.WriteLine();

        } while (!sair);// while final 1
    }

}