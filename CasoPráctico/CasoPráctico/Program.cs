using System;
using System.ComponentModel.Design;

class Program
{
    // Función que retorna el número del dado, su parámetro depende del número de dados
    static int Dado(int numDado)
    {
        // Se crea una instancia de la clase Random
        Random random = new Random();
        // Se especifica el rango
        int numeroDadoEnRango = random.Next(numDado, 6 * numDado);
        return numeroDadoEnRango;
    }
    // Función que devuelve la posición final después de realizar el movimiento
    static int Movimiento(int lanzamiento, int posicion, int final)
    {
        int posicionFinal;
        posicionFinal = posicion + lanzamiento; // En la variable "posicionFinal" se almacena la suma de la posición y el resultado del dado
        if (posicionFinal > final) // Si la posición es mayor al numero de casillas, se quedará en la misma casilla
        {
            posicionFinal = posicion;
        }
        return posicionFinal;
    }
    // Función para avisar el final del juego
    static void Final()
    {
        Console.WriteLine("Felicidades acabaste el juego");
        Console.ReadKey();
    }
    // Función que devuelve la lista que representa el tablero
    static List<int> Tablero(int filas, int columnas)
    {
        List<int> matriz = new List<int>();
        // Se utiliza un bucle para recorrer cada celda del tablero
        for (int i = 1; i <= filas * columnas; i++)
        {
            matriz.Add(i);
        }
        return matriz;
    }
    // Prueba de validación: Función que recibe la posición actual, por si se quiere cambiar la posición inicial
    static void US1UAT1(int posicion) 
    {
        Console.WriteLine("Su posición actual es: " + posicion);
    }
    // Prueba de validación: Función que valida el movimiento de tres espacios
    static void US1UAT2()
    {
        int numPosicion = 1;
        int numMovimiento = 3;
        Console.WriteLine("Su posición actual es: " + numPosicion);
        Console.WriteLine("El movimiento a realizar es de tres casillas");
        Console.WriteLine("Precione una tecla para realizar el movimiento");
        Console.ReadKey();
        int numFinal = Movimiento(numMovimiento, numPosicion, 100);
        Console.WriteLine("Su posición actual es: " + numFinal);
    }
    // Prueba de validación: Función que valida el movimiento de cuatro espacios
    static void US1UAT3()
    {
        int numPosicion = 4;
        int numMovimiento = 4;
        Console.WriteLine("Su posición actual es: " + numPosicion);
        Console.WriteLine("El movimiento a realizar es de cuatro casillas");
        Console.WriteLine("Precione una tecla para realizar el movimiento");
        Console.ReadKey();
        int numFinal = Movimiento(numMovimiento, numPosicion, 100);
        Console.WriteLine("Su posición actual es: " + numFinal);
    }
    // Prueba de validación: Función que valida el movimiento de tres espacios y valida que el juego termine
    static void US2UAT1()
    {
        int numPosicion = 97;
        int numMovimiento = 3;
        Console.WriteLine("Su posición actual es: " + numPosicion);
        Console.WriteLine("El movimiento a realizar es de tres casillas");
        Console.WriteLine("Precione una tecla para realizar el movimiento");
        Console.ReadKey();
        int numFinal = Movimiento(numMovimiento, numPosicion, 100);
        Console.WriteLine("Su posición actual es: " + numFinal);
        Final();
    }
    // Prueba de validación: Función que valida el movimiento de cuatro espacios y valida que el juego no termine
    static void US2UAT2()
    {
        int numPosicion = 97;
        int numMovimiento = 4;
        Console.WriteLine("Su posición actual es: " + numPosicion);
        Console.WriteLine("El movimiento a realizar es de cuatro casillas");
        Console.WriteLine("Precione una tecla para realizar el movimiento");
        Console.ReadKey();
        int numFinal = Movimiento(numMovimiento, numPosicion, 100);
        Console.WriteLine("Su posición actual es: " + numFinal);
    }
    // Prueba de validación: Función que valida el resultado del lanzamiento del dado
    static void US3UAT1()
    {
        int numDado = 1;
        int resultadoDado = Dado(numDado);
        Console.WriteLine("El resultado del lanzamiento del dado es: " + resultadoDado);
    }
    // Prueba de validación: Función que valida el movimiento de cuatro espacios
    static void US3UAT2()
    {
        int numPosicion = 50;
        int numMovimiento = 4;
        Console.WriteLine("Su posición actual es: " + numPosicion);
        Console.WriteLine("El movimiento a realizar es de cuatro casillas");
        Console.WriteLine("Precione una tecla para realizar el movimiento");
        Console.ReadKey();
        int numFinal = Movimiento(numMovimiento, numPosicion, 100);
        Console.WriteLine("Su posición actual es: " + numFinal);
    }
    static void Main()
    {
        int numDado = 1; // Hace referencia al número de dados que se tiene
        int posicion = 1; // Es la posición inicial donde comienza la partida
        int numFilas = 10;
        int numColumnas = 10;
        string op1;
        do
        {
            // Menú de opciones
            Console.WriteLine("1. Desea jugar ?");
            Console.WriteLine("2. Desea realizar pruebas ?");
            Console.Write("Escoja la opción: ");
            string op2 = Console.ReadLine();
            switch (op2)
            {
                case "1":
                    {
                        List<int> listPosicionesTablero = Tablero(numFilas, numColumnas); // Primero se arma el tablero con las posiciones
                        while (posicion < (numFilas * numColumnas))
                        {
                            Console.WriteLine("Su posición actual es: " + posicion);
                            Console.WriteLine("Precione una tecla para lanzar el dado");
                            Console.ReadKey();
                            int numResultadoDado = Dado(numDado);
                            Console.WriteLine("El lanzamiento del dado fue: " + numResultadoDado);
                            posicion = Movimiento(numResultadoDado, posicion, (numFilas * numColumnas));
                        }
                        Final();
                        posicion = 1;
                    }
                break;
                case "2":
                    {
                        // Menú para realizar las pruebas de validación
                        Console.WriteLine("1. US1-UAT1");
                        Console.WriteLine("2. US1-UAT2");
                        Console.WriteLine("3. US1-UAT3");
                        Console.WriteLine("4. US2-UAT1");
                        Console.WriteLine("5. US2-UAT2");
                        Console.WriteLine("6. US3-UAT1");
                        Console.WriteLine("7. US3-UAT2");
                        Console.Write("Escoja la opción: ");
                        string op3 = Console.ReadLine();
                        switch (op3)
                        {
                            case "1":
                                {
                                    US1UAT1(posicion);
                                }
                            break;
                            case "2":
                                {
                                    US1UAT2();
                                }
                            break;
                            case "3":
                                {
                                    US1UAT3();
                                }
                            break;
                            case "4":
                                {
                                    US2UAT1();
                                }
                            break;
                            case "5":
                                {
                                    US2UAT2();
                                }
                            break;
                            case "6":
                                {
                                    US3UAT1();
                                }
                            break;
                            case "7":
                                {
                                    US3UAT2();
                                }
                            break;
                        }
                    }
                break;
            }
            Console.Write("Desea jugar nuevamente S / N: ");
            op1 = Console.ReadLine();
        } while (op1 == "S");
    }
}
