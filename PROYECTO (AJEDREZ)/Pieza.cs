namespace PROYECTO__AJEDREZ_;

public class Pieza
{
    public string Color;

    public string Tipo;

    public char Posicion;
    public string PosicionColumna;
    public string PosicionFila;

    public Pieza()
    {
        Color = "";
        Tipo = "";

    }

    public void PedirDatosPieza()
    {
        Console.WriteLine("Elegir un tipo de pieza:"); //Se creó un menú para pedirle al usuario el tipo de pieza que quiere agregar al tablero
        Console.WriteLine("1. Alfil");
        Console.WriteLine("2. Peón");
        Console.WriteLine("3. Caballo");
        Console.WriteLine("4. Torre");
        Console.WriteLine("5. Rey");
        int OpcionElegida = int.Parse(Console.ReadLine());
        switch (OpcionElegida) //Según la opción elegida, se asigna un tipo de pieza
        {
            case 1:
                Tipo = "Alfil";
                break;

            case 2:
                Tipo = "Peón";
                break;

            case 3:
                Tipo = "Caballo";
                break;

            case 4:
                Tipo = "Torre";
                break;

            case 5:
                Tipo = "Rey";
                break;

            default:
                Console.WriteLine("La opción ingresada no es válida, ingrese otra");
                break;
        }

        Console.WriteLine("Ingrese el color de la pieza"); //Menú que pregunta al usuario el color de la pieza que desea agregar al tablero
        Console.WriteLine("1. Blanco");
        Console.WriteLine("2. Negro");
        int OpcionColor = int.Parse(Console.ReadLine());
        switch (OpcionColor) //Asigna el color de la pieza
        {
            case 1:
                Color = "Blanco";
                break;

            case 2:
                Color = "Negro";
                break;

            default:
                Console.WriteLine("El color ingresado es inválido");
                break;
        }


        Console.WriteLine("Ingrese la letra de la columna que desea:"); //Menú que pregunta la columna a la que el usuario desea agregar la pieza 
        Console.WriteLine("1. a");
        Console.WriteLine("2. b");
        Console.WriteLine("3. c");
        Console.WriteLine("4. d");
        Console.WriteLine("5. e");
        Console.WriteLine("6. f");
        Console.WriteLine("7. g");
        Console.WriteLine("8. h");
        int Opcioncolumna = int.Parse(Console.ReadLine());
        switch (Opcioncolumna)
        {
            case 1:
                PosicionColumna = "a";
                break;

            case 2:
                PosicionColumna = "b";
                break;

            case 3:
                PosicionColumna = "c";
                break;

            case 4:
                PosicionColumna = "d";
                break;

            case 5:
                PosicionColumna = "e";
                break;

            case 6:
                PosicionColumna = "f";
                break;

            case 7:
                PosicionColumna = "g";
                break;

            case 8:
                PosicionColumna = "h";
                break;

            default:
                Console.WriteLine("La opción ingresada es inválida");
                break;
        }

        Console.WriteLine("Ingrese el número de la fila que desea:"); //Menú que pregunta la fila a la que el usuario desea agregar la pieza 
        Console.WriteLine("1. 1");
        Console.WriteLine("2. 2");
        Console.WriteLine("3. 3");
        Console.WriteLine("4. 4");
        Console.WriteLine("5. 5");
        Console.WriteLine("6. 6");
        Console.WriteLine("7. 7");
        Console.WriteLine("8. 8");
        int OpcionFila = int.Parse(Console.ReadLine());
        switch (OpcionFila)
        {
            case 1:
                PosicionFila = "1";
                break;

            case 2:
                PosicionFila = "2";
                break;

            case 3:
                PosicionFila = "3";
                break;

            case 4:
                PosicionFila = "4";
                break;

            case 5:
                PosicionFila = "5";
                break;

            case 6:
                PosicionFila = "6";
                break;

            case 7:
                PosicionFila = "7";
                break;

            case 8:
                PosicionFila = "8";
                break;

            default:
                Console.WriteLine("La opción ingresada es inválida");
                break;
        }
    }

    public void PedirDatosDama()
    {
        Tipo = "Dama"; //Asigna el tipo de pieza como Dama
        Console.WriteLine("Ingrese el color de la pieza"); //Menú que pide el color de la dama 
        Console.WriteLine("1. Blanco");
        Console.WriteLine("2. Negro");
        int OpcionColor = int.Parse(Console.ReadLine());
        switch (OpcionColor)
        {
            case 1:
                Color = "Blanco";
                break;

            case 2:
                Color = "Negro";
                break;

            default:
                Console.WriteLine("El color ingresado es inválido");
                break;
        }


        Console.WriteLine("Ingrese la letra de la columna que desea:"); //Menú que pide la columna a la que desea agregarse la dama 
        Console.WriteLine("1. a");
        Console.WriteLine("2. b");
        Console.WriteLine("3. c");
        Console.WriteLine("4. d");
        Console.WriteLine("5. e");
        Console.WriteLine("6. f");
        Console.WriteLine("7. g");
        Console.WriteLine("8. h");
        int Opcioncolumna = int.Parse(Console.ReadLine());
        switch (Opcioncolumna)
        {
            case 1:
                PosicionColumna = "a";
                break;

            case 2:
                PosicionColumna = "b";
                break;

            case 3:
                PosicionColumna = "c";
                break;

            case 4:
                PosicionColumna = "d";
                break;

            case 5:
                PosicionColumna = "e";
                break;

            case 6:
                PosicionColumna = "f";
                break;

            case 7:
                PosicionColumna = "g";
                break;

            case 8:
                PosicionColumna = "h";
                break;

            default:
                Console.WriteLine("La opción ingresada es inválida");
                break;
        }


        Console.WriteLine("Ingrese el número de la fila que desea:"); //Menú que pregunta la fila a la que se desea agregar la dama
        Console.WriteLine("1. 1");
        Console.WriteLine("2. 2");
        Console.WriteLine("3. 3");
        Console.WriteLine("4. 4");
        Console.WriteLine("5. 5");
        Console.WriteLine("6. 6");
        Console.WriteLine("7. 7");
        Console.WriteLine("8. 8");
        int OpcionFila = int.Parse(Console.ReadLine());
        switch (OpcionFila)
        {
            case 1:
                PosicionFila = "1";
                break;

            case 2:
                PosicionFila = "2";
                break;

            case 3:
                PosicionFila = "3";
                break;

            case 4:
                PosicionFila = "4";
                break;

            case 5:
                PosicionFila = "5";
                break;

            case 6:
                PosicionFila = "6";
                break;

            case 7:
                PosicionFila = "7";
                break;

            case 8:
                PosicionFila = "8";
                break;

            default:
                Console.WriteLine("La opción ingresada es inválida");
                break;
        }
    }
}