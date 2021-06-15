using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNotacaoPosicional
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDecimalInteiroBinario();

            Console.ReadLine();
        }

        static void CalculadoraBinarioDecimal() //Converter número binário para decimal.
        {
            string stringBinario;
            int intCasaBinario;
            string casaBinario;
            double baseBinario = 2;
            double operacao;
            double resultadoDecimal = 0;
            double expoente;

            Console.WriteLine("Digite o número BINÁRIO que deseja converter para DECIMAL");
            stringBinario = Console.ReadLine();

            expoente = stringBinario.Length - 1;

            for (int i = 0; i < stringBinario.Length; i++)
            {
                casaBinario = stringBinario.Substring(i, 1);
                intCasaBinario = Convert.ToInt32(casaBinario);
                operacao = intCasaBinario * (Math.Pow(baseBinario, expoente));
                resultadoDecimal += operacao;
                expoente--;
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Conversão de BINÁRIO para DECIAML:");
            Console.WriteLine($"Binário: {stringBinario}");
            Console.WriteLine($"Decimal: {resultadoDecimal}");
            Console.WriteLine("-----------------------------------------------");
        }

        static void CalculadoraDecimalInteiroBinario() //Converte número decimal inteiro para binário.
        {
            int ConvertDecimal;
            int numDecimal;
            string stgBinario = null;
            int numBase = 2;
            int restoDaDivisao;
            string CaracBinario;
            int numBinario;
            
            Console.WriteLine("Digite o número DECIMAL INTEIRO que deseja converter para BINÁRIO");
            ConvertDecimal = Convert.ToInt32(Console.ReadLine());
            numDecimal = ConvertDecimal;

            do
            {
                restoDaDivisao = numDecimal % numBase;
                numDecimal = numDecimal / numBase;
                CaracBinario = restoDaDivisao.ToString();
                if (stgBinario == null)
                {
                    stgBinario = CaracBinario;
                }
                else
                {
                    stgBinario = CaracBinario + stgBinario;
                }
            }
            while (numDecimal > 0);

            numBinario = Convert.ToInt32(stgBinario);

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Conversão de DECIMAL INTEIRO para BINÁRIO:");
            Console.WriteLine($"Decimal: {ConvertDecimal}");
            Console.WriteLine($"Binario: {numBinario}");
            Console.WriteLine("-----------------------------------------------");
        }

    }
}
