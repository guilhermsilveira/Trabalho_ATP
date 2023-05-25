﻿

class Program
{

    // METODO QUE CONTA QUANTAS LINHAS TEM O MAPA INFORMADO
    public static int contLinhas(string x)
    {
        int linhas = 0;

        for (int i = 0; i <=x.Length-1; i++)
        {

            if (x[i] == '\n')
            {
                linhas++;

            }
        }
        return linhas+1;
    }

    //METODO QUE CONTA QUANTAS COLUNAS TEM O MATA INFORMADO
    public static int contColunas(string x)
    {
        int colunas = 0;

        for (int i = 0; i <= x.Length-1; i++)
        {
            if (x[i] != '\n')
            {
                colunas++;

            }
            else
            {
                break;
            }
        }
        return colunas+1;
    }


    static void Main()
    {

        // VARIAVEL QUE RECEBERA DO USUÁRIO O LOCAL ONDE ESTA O MAPA 

       // Console.WriteLine("Digite o caminho do arquivo mapa: ");
        string caminho = @"C:\mapasteste\mapa2.txt";


        // VERIFICA SE O CAMINHO INFORMADO EXISTE 
        try
        {
            string conteudo = File.ReadAllText(caminho);
            conteudo = conteudo.Replace(" ","");
            

            int linhas = contLinhas(conteudo);
            int colunas = contLinhas(conteudo);

            string mapavet = conteudo.Replace("\n", "").Replace("\r", "");
            Console.WriteLine("\n" + mapavet + "\n");

            Console.WriteLine("Colunas: " + colunas + "\nLinhas: "+ linhas + "\nTamanho: " +conteudo.Length);

        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo não encontrado! \nLembre de adicionar o caminho do mapa desejado dessa forma:  ex:'C:\\mapasexemplos\\mapa1.txt' ");
        }

    }
}