using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_OO_Alternativa_01
{
    internal class DataBase
    {
		/// <summary>
		/// Método da classe DataBase, ler arquivo linha a linha e retorna uma lista do tipo string com os dados da leitura
		/// </summary>
		/// <param name="nomeDoArquivo"></param>
        public static List<string> realizarLeituraDoArquivo(string nomeDoArquivo)
        {
			try
			{
				StreamReader leitor = new StreamReader(nomeDoArquivo);
				List<string> lista = new List<string>();

                do
				{
					string linha = leitor.ReadLine();
					lista.Add(linha);
					
                } while (!leitor.EndOfStream);

                return lista;
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
