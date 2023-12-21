using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_.Models
{
    public class JogoDaVelha
    {
        string[,] matriz = new string[3, 3];

        string ganhador = "";

        int contador = 10;

        string turno = "X";


        string a1 = "'";
        string a2 = "'";
        string a3 = "'";
        string b1 = "'";
        string b2 = "'";
        string b3 = "'";
        string c1 = "'";
        string c2 = "'";
        string c3 = "'";

        int um = 0;
        int dois = 0;
        int tres = 0;
        int quatro = 0;
        int cinco = 0;
        int seis = 0;
        int sete = 0;
        int oito = 0;
        int nove = 0;



        public void DesenharMatriz()
        {
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (coluna == matriz.GetLongLength(1) - 1)
                    {
                        Console.WriteLine(AnexarVariaveis(linha, coluna));
                    }
                    else
                    {
                        Console.Write(AnexarVariaveis(linha, coluna) + " - ");
                    }

                }
            }
        }

        public string AnexarVariaveis(int linha, int coluna)
        {

            if (linha == 0 && coluna == 0)
            {
                return a1;
            }
            else if (linha == 0 && coluna == 1)
            {
                return a2;
            }
            else if (linha == 0 && coluna == 2)
            {
                return a3;
            }
            else if (linha == 1 && coluna == 0)
            {
                return b1;
            }
            else if (linha == 1 && coluna == 1)
            {
                return b2;
            }
            else if (linha == 1 && coluna == 2)
            {
                return b3;
            }
            else if (linha == 2 && coluna == 0)
            {
                return c1;
            }
            else if (linha == 2 && coluna == 1)
            {
                return c2;
            }

            return c3;
        }

        public string GetTurno()
        {
            return turno;
        }

        public void TrocaTurnos()
        {
            if (turno == "X")
            {
                turno = "Y";
            }
            else
            {
                turno = "X";
            }

            contador++;
        }

        public void TrocarVariaveis(int escolha)
        {

            if (escolha == 1 && turno == "X" && um == 0)
            {
                um = 1;
                a1 = "X";
                TrocaTurnos();
            }
            else if (escolha == 1 && turno == "Y" && um == 0)
            {
                um = 1;
                a1 = "O";
                TrocaTurnos();
            }
            else if (escolha == 2 && turno == "X" && dois == 0)
            {
                dois = 1;
                a2 = "X";
                TrocaTurnos();
            }
            else if (escolha == 2 && turno == "Y" && dois == 0)
            {
                dois = 1;
                a2 = "O";
                TrocaTurnos();
            }
            else if (escolha == 3 && turno == "X" && tres == 0)
            {
                tres = 1;
                a3 = "X";
                TrocaTurnos();
            }
            else if (escolha == 3 && turno == "Y" && tres == 0)
            {
                tres = 1;
                a3 = "O";
                TrocaTurnos();
            }
            else if (escolha == 4 && turno == "X" && quatro == 0)
            {
                quatro = 1;
                b1 = "X";
                TrocaTurnos();
            }
            else if (escolha == 4 && turno == "Y" && quatro == 0)
            {
                quatro = 1;
                b1 = "O";
                TrocaTurnos();
            }
            else if (escolha == 5 && turno == "X" && cinco == 0)
            {
                cinco = 1;
                b2 = "X";
                TrocaTurnos();
            }
            else if (escolha == 5 && turno == "Y" && cinco == 0)
            {
                cinco = 1;
                b2 = "O";
                TrocaTurnos();
            }
            else if (escolha == 6 && turno == "X" && seis == 0)
            {
                seis = 1;
                b3 = "X";
                TrocaTurnos();
            }
            else if (escolha == 6 && turno == "Y" && seis == 0)
            {
                seis = 1;
                b3 = "O";
                TrocaTurnos();
            }
            else if (escolha == 7 && turno == "X" && sete == 0)
            {
                sete = 1;
                c1 = "X";
                TrocaTurnos();
            }
            else if (escolha == 7 && turno == "Y" && sete == 0)
            {
                sete = 1;
                c1 = "O";
                TrocaTurnos();
            }
            else if (escolha == 8 && turno == "X" && oito == 0)
            {
                oito = 1;
                c2 = "X";
                TrocaTurnos();
            }
            else if (escolha == 8 && turno == "Y" && oito == 0)
            {
                oito = 1;
                c2 = "O";
                TrocaTurnos();
            }
            else if (escolha == 9 && turno == "X" && nove == 0)
            {
                nove = 1;
                c3 = "X";
                TrocaTurnos();
            }
            else if (escolha == 9 && turno == "Y" && nove == 0)
            {
                nove = 1;
                c3 = "O";
                TrocaTurnos();
            }

        }



        public bool AcabouOuNao()
        {
            if (contador >= 19 || ganhador != "")
            {
                return true;
            }

            return false;
        }

        public void ChecarCondicoesDeVitoria()
        {
            if (
                a1 == "X" && a2 == "X" && a3 == "X" ||
                a1 == "X" && b1 == "X" && c1 == "X" ||
                a1 == "X" && b2 == "X" && c3 == "X" ||
                a2 == "X" && b2 == "X" && c2 == "X" ||
                a3 == "X" && b3 == "X" && c3 == "X" ||
                c1 == "X" && c2 == "X" && c3 == "X" ||
                b1 == "X" && b2 == "X" && b3 == "X" ||
                c1 == "X" && b2 == "X" && a3 == "X"
                )
            {
                ganhador = "X";
            }
            else if (
                a1 == "O" && a2 == "O" && a3 == "O" ||
                a1 == "O" && b1 == "O" && c1 == "O" ||
                a1 == "O" && b2 == "O" && c3 == "O" ||
                a2 == "O" && b2 == "O" && c2 == "O" ||
                a3 == "O" && b3 == "O" && c3 == "O" ||
                c1 == "O" && c2 == "O" && c3 == "O" ||
                b1 == "O" && b2 == "O" && b3 == "O" ||
                c1 == "O" && b2 == "O" && a3 == "O"
                )
            {
                ganhador = "O";
            }
        }

        public string GetGanhador()
        {
            if (contador >= 19)
            {
                return "Velha";
            }

            return ganhador;
        }

        public void ReiniciarJogo()
        {
            ganhador = "";

            contador = 10;

            turno = "X";


            a1 = "'";
            a2 = "'";
            a3 = "'";
            b1 = "'";
            b2 = "'";
            b3 = "'";
            c1 = "'";
            c2 = "'";
            c3 = "'";

            um = 0;
            dois = 0;
            tres = 0;
            quatro = 0;
            cinco = 0;
            seis = 0;
            sete = 0;
            oito = 0;
            nove = 0;

        }

    }


}