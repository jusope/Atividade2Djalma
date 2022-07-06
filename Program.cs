using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2Djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
			double dia, mes, ano, cod;
			string cdd = null, mesextenso = null;

			Console.WriteLine("Digite o código da cidade que deseja: ");
			Console.WriteLine();

			Console.WriteLine("1. Atibaia");
			Console.WriteLine("2. Bragança Paulista");
			Console.WriteLine("3. Mairiporã");
			Console.WriteLine("4. Nazaré");
			Console.WriteLine("5. Terra Preta");
			Console.WriteLine("6. Extrema");
			Console.WriteLine("7. Vargem");

			Console.WriteLine();
			cod = double.Parse(Console.ReadLine());


			switch (cod)
			{
				case 1:
					cdd = "Atibaia";
					break;
				case 2:
					cdd = "Bragança Paulista";
					break;
				case 3:
					cdd = "Mairiporã";
					break;
				case 4:
					cdd = "Nazaré";
					break;
				case 5:
					cdd = "Terra Preta";
					break;
				case 6:
					cdd = "Extrema";
					break;
				case 7:
					cdd = "Vargem";
					break;
			}

			Console.WriteLine();
			Console.WriteLine("Digite uma data");
			Console.WriteLine("Dia:");
			dia = double.Parse(Console.ReadLine());
			Console.WriteLine("Mês:");
			mes = double.Parse(Console.ReadLine());

			switch (mes)
			{
				case 1:
					mesextenso = "Janeiro";
					break;
				case 2:
					mesextenso = "Fevereiro";
					break;
				case 3:
					mesextenso = "Março";
					break;
				case 4:
					mesextenso = "Abril";
					break;
				case 5:
					mesextenso = "Maio";
					break;
				case 6:
					mesextenso = "Junho";
					break;
				case 7:
					mesextenso = "Julho";
					break;
				case 8:
					mesextenso = "Agosto";
					break;
				case 9:
					mesextenso = "Setembro";
					break;
				case 10:
					mesextenso = "Outubro";
					break;
				case 11:
					mesextenso = "Novembro";
					break;
				case 12:
					mesextenso = "Dezembro";
					break;
			}


			Console.WriteLine("Ano:");
			ano = double.Parse(Console.ReadLine());

			Console.WriteLine();
			Console.WriteLine(cdd + ", " + dia + " de " + mesextenso + " de " + ano + ".");

			Console.ReadKey();
		}
    }
}
