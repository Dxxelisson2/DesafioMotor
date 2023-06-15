using System.Drawing;

internal class Program
{
    //funções 

    //===============================================================================================================================

    //Array
    static double[] gastosMotores = new double[15];


    //===============================================================================================================================

    //função que lança o gasto de cada motor
    static void lancargastos()
    {
        int qualMotor;
        double valor;

        Console.Clear();
        Console.WriteLine("Lançar Gastos: ");

        do
        {
            Console.Write("Digite o número do motor: ");
            qualMotor = int.Parse(Console.ReadLine());  
        }
        while (qualMotor < 1 || qualMotor > 15);


        do
        {

            Console.Write("Digite o valor do gasto: ");
            valor = double.Parse(Console.ReadLine()); //armazena na variavel valor


            if (valor >= 0)
            {
                Console.Clear();
                Console.WriteLine("Gasto lançado com sucesso!");
                // Ler e validar o valor do gasto digitado pelo usuário

                gastosMotores[qualMotor-1] += valor;
           
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
        Console.WriteLine("Gastos:");

        double totalGastos = 0; // variável para armazenar o valor total dos gastos

        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine($"Motor {i + 1}: R$ {gastosMotores[i]}"); // exibe gasto de cada motor
            totalGastos += gastosMotores[i]; // adiciona o gasto atual ao total
        }

        Console.WriteLine($"Valor total Gasto: R$ {totalGastos}");
    }



    //===============================================================================================================================

    //função motor que mais gastou

    static void motorquemaisgastou()                          
    {
        Console.Clear();
        Console.WriteLine(" Motor com maior gasto: ");


        double maiorGasto = gastosMotores[0];
        int motorMaisGastou = 0;

        for (int i = 1; i < 15; i++)
        {
            if (gastosMotores[i] > maiorGasto)
            {
                maiorGasto = gastosMotores[i];
                motorMaisGastou = i;
            }
        }

        if (maiorGasto > 0) //verifica se foi lançado valor em algum motor.
            
            Console.WriteLine($"Motor que mais gastou: {motorMaisGastou + 1} (R$ {maiorGasto})");

        else Console.WriteLine("Não houve gastos");
    



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