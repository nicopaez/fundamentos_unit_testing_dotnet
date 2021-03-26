using System;

namespace PruebasString
{
    public static class Assert
    {
        public static void Que(bool condicion)
        {
            if (!condicion)
                throw new Exception("Assertion error");
        }
    }
}
