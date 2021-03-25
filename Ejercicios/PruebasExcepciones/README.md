Ejercicio prueba de excepciones
===============================

Dado el siguiente código:

````
Func<int, int, int> dividir = (int dividendo, int divisor) => dividendo / divisor;

int[] items = new[] {1, 2};

ArrayList arr = null;

````

Verificar:

* Que la funcion dividir lanza una DivideByZeroException cuando el divisor es 0
* Que acceder al tercer elementos del array items lanza IndexOutOfRangeException
* Que invocar el método Clear (o cualquier otro método) sobre la referencia arr lanza NullReferenceException 



