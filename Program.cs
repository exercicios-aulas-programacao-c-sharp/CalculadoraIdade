using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataAtual = DateTime.Now;
            DateTime diaDoMeuNascimento = new DateTime(1986, 11, 05, 16, 20, 00);

            TimeSpan intervaloVivido = dataAtual - diaDoMeuNascimento;

            string dataCurta = diaDoMeuNascimento.ToShortDateString();
            int intervaloEmDias = intervaloVivido.Days;

            Console.WriteLine($"Eu nasci em {dataCurta} e já vivi {intervaloEmDias} dias");

        }
    }
}
