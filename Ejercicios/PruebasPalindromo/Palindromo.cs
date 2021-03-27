using System;

namespace PruebasPalindromo
{
    public class Palindromo
    {
        public static bool EsPalindromo(string palabra)
        {
            var palabraNormalizada = palabra.Replace(" ", String.Empty);
            var i = 0;
            var a = 0;

            char[] chr = palabraNormalizada.ToCharArray();
            foreach (char cr in chr)
            {
                Array.Reverse(chr);
                if (chr[i] == cr)
                {
                    if (a == palabraNormalizada.Length)
                    {
                        return true;
                    }
                    a++;
                    i++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
