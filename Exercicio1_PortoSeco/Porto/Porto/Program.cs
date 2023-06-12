using Porto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 static bool IsNumeric(object Expression)
{
    double retNum;

    bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
    return isNum;
}
//Criar pilhas para cada local
Pilha pilha1 = new Pilha();
Pilha pilha2 = new Pilha();
Pilha pilha3 = new Pilha();
Pilha pilha4 = new Pilha();
bool sair = false;
string opcao ="0";
int aux = 0;
int aux2 = 0;
//Definir espaços para cada pilha de cada local
Pilha[] porto = {pilha1,pilha2,pilha3,pilha4};


while (sair == false && IsNumeric(opcao))
{
    //Imprimir pilhas completas
    for(int n = 0; n < porto.Length; n++)
    {
        porto[n].imprime(porto[n].quantPilha());
     }
    //Definir para usuário qual opção escolher: Remover ou Inserir
    Console.WriteLine("\nDefina qual opção escolher:");
    Console.WriteLine("[1] - Adicionar Container");
    Console.WriteLine("[2] - Remover Container");
    Console.WriteLine("[3] - SAIR");


    opcao = Console.ReadLine();
    

    switch (Convert.ToInt32(opcao))
    {
        //Adicionar Container
        case 1:
            Console.WriteLine("Digite o código deste container");//Entrada do código
            string codigo = Console.ReadLine();
            //Vetor para armazenar quantos containers tem na pilha
            int[] quant = { porto[0].quantPilha(), porto[1].quantPilha(), porto[2].quantPilha(), porto[3].quantPilha() };
            //Varredura para encontrar pilha menos cheia
            for(int i = 0; i < quant.Length; i++)
            {
                
                if (porto[i].quantPilha()<=aux)
                {
                    aux = porto[i].quantPilha();
                    aux2 = i;
                }
            }
            //Teste para verificar existencia de código e adicionar
            for (int i = 0; i < porto.Length; i++)
            {
                if (porto[i].codigoExiste(codigo))
                {
                    Console.WriteLine("Codigo Invalido!!");
                    break;
                }
                else if(i == porto.Length - 1)
                {
                    Console.WriteLine("Código adicionado com sucesso!!");
                    if (porto[aux2].estaCheia())
                    {
                        Console.WriteLine("\nImpossível Empilhar !!\n");
                    }
                    else
                    {
                        porto[aux2].inserir(codigo);
                        
                    }
                    break;
                }
            }
            aux++;
            break;
            //Fim do Adicionar

        case 2:
            //Remover container
            Console.WriteLine("\nDigite o código do container a ser removido:\n");
            string codigoR = Console.ReadLine();

            for (int i = 0; i < porto.Length; i++)
            {
                if (porto[i].codigoExiste(codigoR) && (porto[i].Topo.Codigo == codigoR))
                {
                    porto[i].remover();
                    Console.WriteLine("Codigo Removido!!");
                    break;
                }
                else
                {
                    porto[i].imprime(porto[i].quantPilha());
                }

            }
            break;

            case 3:
                sair = true;
                break; 
    }
    Environment.Exit(0);
}







