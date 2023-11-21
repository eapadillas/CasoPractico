using System;
using System.ComponentModel.Design;

class Program
{
    //
    static int Dado(int d)
    {
        // Crear una instancia de la clase Random
        Random random = new Random();

        // Se especifica el rango
        int numeroDadoEnRango = random.Next(d, 6 * d);

        return numeroDadoEnRango;
    }
    //
    static int Movimiento(int Lanzamiento, int Posicion, int Final)
    {
        int posicionFinal;
        posicionFinal = Posicion + Lanzamiento; //Se suma la posición y el resultado del dado
        if (posicionFinal > Final) //Si la posicion es mayor al numero de casillas, se quedara en la misma casilla
        {
            posicionFinal = Posicion;
        }
        return posicionFinal;
    }
    //
    static void Final()
    {
        Console.WriteLine("Felicidades acabaste el juego");
        Console.ReadKey();
    }
    //
    static List<int> Tablero(int filas, int columnas)
    {
        List<int> matriz = new List<int>();

        for (int i = 1; i <= filas * columnas; i++)
        {
            matriz.Add(i);
        }
        return matriz;
    }
    //Se recibe la posicion por si se quiere cambiar la posición inicial.
    static void US1UAT1(int posicion) 
    {
        Console.WriteLine("Su posición actual es: " + posicion);
    }
    //
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
    //
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
    //
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
    //
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
    //
    static void US3UAT1()
    {
        int numDado = 1;
        int resultadoDado = Dado(numDado);
        Console.WriteLine("El resultado del lanzamiento del dado es: " + resultadoDado);
    }
    //
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
        int numDado = 1; //Hace referencia al número de dados que se tiene
        int posicion = 1; //Es la posición inicial donde comienza la partida
        int numFilas = 3; //
        int numColumnas = 3; //
        string op1;
        do
        {
            Console.WriteLine("1. Desea jugar");
            Console.WriteLine("2. Desea realizar pruebas");
            Console.Write("Escoja la opción: ");
            string op2 = Console.ReadLine();
            switch (op2)
            {
                case "1":
                    {
                        List<int> listPosicionesTablero = Tablero(numFilas, numColumnas); //Primero se arma el tablero con las posiciones
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
            Console.Write("Desea jugar de nuevo: S / N: ");
            op1 = Console.ReadLine();
        } while (op1 == "S");
    }
}

