using System;
using System.Text;

namespace RecapTiposOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----------------------------------------------------------------------");
            
            Console.WriteLine($"Tipo De Dado: {new BOol.GetBool().Titulo}");
            Console.WriteLine("========================================================================");
            Console.WriteLine($"Primeiro tipo aguardado: {new BOol.GetBool().Verdadeiro} = à verdadeiro");
            Console.WriteLine($"Segundo tipo aguardado: {new BOol.GetBool().Falso} = à falso");
            
            Console.WriteLine("\n----------------------------------------------------------------------");
            
            Console.WriteLine($"Tipo De Dado: {new BYte.GetByte().Titulo}");
            Console.WriteLine("========================================================================");
            Console.WriteLine($"Primeiro tipo aguardado: {new BYte.GetByte().ByteMin} = à 0");
            Console.WriteLine($"Segundo tipo aguardado: {new BYte.GetByte().ByteMax} = à 255");
            
            Console.WriteLine("\n----------------------------------------------------------------------");
            // Console.WriteLine($"Tipo De Dado: {new BOol.GetBool().Titulo}");
            // Console.WriteLine("========================================================================");
            // Console.WriteLine($"Primeiro tipo aguardado: {new BOol.GetBool().Verdadeiro} = à verdadeiro");
            // Console.WriteLine($"Segundo tipo aguardado: {new BOol.GetBool().Falso} = à falso");
        }
    }
}
