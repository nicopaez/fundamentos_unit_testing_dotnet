using System;
using System.Reflection;

namespace PruebasString
{
    class Program
    {
        static void Main(string[] args)
        {
            var metodos = typeof(Program).GetMethods(BindingFlags.Public | BindingFlags.Static );
            var pruebasExitosas = 0;
            var pruebasFallidas = 0;
            foreach (var metodo  in metodos)
            {
                if (metodo.Name.StartsWith("Prueba"))
                {
                    try
                    {
                        metodo.Invoke(null, null);
                        pruebasExitosas++;
                    }
                    catch
                    {
                        pruebasFallidas++;
                    }

                }
            }
            Console.WriteLine($"Prueba existosas #{pruebasExitosas}");
            Console.WriteLine($"Prueba fallidas #{pruebasFallidas}");
        }

        public static void PruebaQueStringHolaTieneLongitud4()
        {
            // arrange
            var stringHola = "hola";

            // act
            var longitud = stringHola.Length;

            // assert
            Assert.Que(longitud == 4);
        }

        public static void PruebaQueStringHolaContieneCaractera()
        {
            // arrange
            var stringHola = "hola";

            // act
            var contieneLetraa = stringHola.Contains("a");

            // assert
            Assert.Que(contieneLetraa);
        }

        public static void PruebaXXXXXX()
        {
            
        }

    }

}
