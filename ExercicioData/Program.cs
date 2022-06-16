using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string MesExtenso = null;
            int dia, mes, ano;

            Console.WriteLine("Digite a data (dd/mm/aaaa): ");
            var DataAtual = Convert.ToDateTime(Console.ReadLine());

            mes = DataAtual.Month;
            dia = DataAtual.Day;
            ano = DataAtual.Year;

            switch(mes)
            {
                case 1:
                    MesExtenso = "Janeiro";
                    break;
                case 2:
                    MesExtenso = "Fevereiro";
                    break;
                case 3:
                    MesExtenso = "Março";
                    break;
                case 4:
                    MesExtenso = "Abril";
                    break;
                case 5:
                    MesExtenso = "Maio";
                    break;
                case 6:
                    MesExtenso = "Junho";
                    break;
                case 7:
                    MesExtenso = "Julho";
                    break;
                case 8:
                    MesExtenso = "Agosto";
                    break;
                case 9:
                    MesExtenso = "Setembro";
                    break;
                case 10:
                    MesExtenso = "Outubro";
                    break;
                case 11:
                    MesExtenso = "Novembro";
                    break;
                case 12:
                    MesExtenso = "Dezembro";
                    break;
            }
            Console.WriteLine(dia + " de " + MesExtenso + " de " + ano);
            Console.ReadKey();


           
        }
    }
}
