using c_.Models;

JogoDaVelha matriz = new JogoDaVelha();

int reinicio = 0;

do
{
    while (matriz.AcabouOuNao() != true)
    {
        matriz.DesenharMatriz();

        if (matriz.GetTurno() == "Y")
        {
            Console.WriteLine("Turno do O");
        }
        else
        {
            Console.WriteLine("Turno do " + matriz.GetTurno());
        }



        Console.Write("Digite a posição (1 a 9): ");

        var escolha = Console.ReadLine();

        int resultado;

        int.TryParse(escolha, out resultado);


        matriz.TrocarVariaveis(resultado);

        matriz.ChecarCondicoesDeVitoria();


        if (matriz.AcabouOuNao() != true)
        {
            Console.Clear();
        }
    }

    Console.Clear();

    Console.WriteLine("Ganhador: " + matriz.GetGanhador());
    matriz.DesenharMatriz();
    Console.ReadLine();

    string opcao;

    do
    {
        Console.WriteLine("Jogar denovo? (s/n)");
        opcao = Console.ReadLine();

    } while (opcao != "s" && opcao != "S" && opcao != "n" && opcao != "N");

    if (opcao == "s" || opcao == "S")
    {
        matriz.ReiniciarJogo();
        Console.Clear();
        reinicio = 1;
    }
    else
    {
        reinicio = 0;
        Console.Clear();
    }


} while (reinicio == 1);


