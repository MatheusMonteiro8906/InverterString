using System;

namespace InverterString
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringTeste = "InvertaIsso";
            string StringInvertida = InverterString(stringTeste);

            Console.Write("string original: " + stringTeste + Environment.NewLine);
            Console.Write("string invertida: " + StringInvertida);

            Console.ReadLine();
        }
        private static string InverterString(string stringTeste)
        {
            string StringInvertida = "";
            for (int contador = stringTeste.Length - 1; contador >= 0; contador--)
            {
                StringInvertida += stringTeste[contador];
            }
            return StringInvertida;
        }
    }
}
