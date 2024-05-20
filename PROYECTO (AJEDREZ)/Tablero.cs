namespace PROYECTO__AJEDREZ_;

public class Tablero
{
    public Pieza[,] tablero = new Pieza[8, 8]; // Fue creada una matriz de 8x8 para la creación del tablero
    public int DatosColumna;
    public int DatosFila;

    public string[] Columna = new string[8] { "a", "b", "c", "d", "e", "f", "g", "h", };   //Arreglos para representar las columnas y filas del tablero
    public string[] Fila = new string[8] { "8", "7", "6", "5", "4", "3", "2", "1" };


    public void GuardarDatosPieza()  //Método para guardar una pieza en el tablero
    {
        Pieza objpieza = new Pieza();
        objpieza.PedirDatosPieza(); //Guarda los datos de la pieza que fueron ingresados por el usuario
        for (int i = 0; i < 8; i++) 
        {
            if (Columna[i] == objpieza.PosicionColumna)
            {
                DatosColumna = i;
            }
            if (Fila[i] == objpieza.PosicionFila)
            {
                DatosFila = i;
            }
        }
        if (tablero[DatosFila, DatosColumna] == null) // Si la casilla está vacia, guarda la pieza en esta posición
        {

            tablero[DatosFila, DatosColumna] = objpieza; //En este atributo se guarda todo lo del objeto pieza

        }
        else
        {
            Console.WriteLine("La casilla no puede ser utilizada, debido a que está ocupada");
        }
    }


    public void GuardarDatosDama()  //Método para guardar específicamente los datos de la dama
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Ahora deberá ingresar los datos de la dama que desea evaluar");
        Console.WriteLine("----------------------------------------------------------------");

        Pieza objpieza = new Pieza();
        objpieza.PedirDatosDama();  // Solicita los datos para la dama

        for (int i = 0; i < 8; i++)
        {
            if (Columna[i] == objpieza.PosicionColumna)
            {
                DatosColumna = i;
            }
            if (Fila[i] == objpieza.PosicionFila)
            {
                DatosFila = i;
            }
        }
        if (tablero[DatosFila, DatosColumna] == null)
        {

            tablero[DatosFila, DatosColumna] = objpieza; //En este atributo se guarda todo lo del objeto pieza

        }
        else
        {
            Console.WriteLine("La casilla no puede ser utilizada, debido a que está ocupada");
        }
    }

    public void MovimientoHorizontalDerecha() //Método para mostrar los posibles movimientos horizontales hacia la derecha a los que la dama se puede mover
    {
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Lista de posibles movimientos y casillas vacías");
        Console.WriteLine("----------------------------------------------------");
        for (int i = DatosColumna + 1; i < 8; i++)
        {
            if (tablero[DatosFila, i] == null)
            {
                Console.WriteLine(Columna[i] + Fila[DatosFila] + " está vacía");
            }

            if (tablero[DatosFila, i] != null && tablero[DatosFila, i].Color != tablero[DatosFila, DatosColumna].Color) //Verifica si hay alguna pieza de color diferente
            {
                Console.WriteLine(Columna[i] + Fila[DatosFila] + " " + tablero[DatosFila, i].Tipo + " " + tablero[DatosFila, i].Color);
                break;
            }
            if (tablero[DatosFila, i] != null)
            {
                break;
            }
        }
    }

    public void MovimientoHorizontalIzquieda()
    {
        for (int i = DatosColumna - 1; i > -1; i--)
        {
            if (tablero[DatosFila, i] == null)
            {
                Console.WriteLine(Columna[i] + Fila[DatosFila] + " está vacía");
            }

            if (tablero[DatosFila, i] != null && tablero[DatosFila, i].Color != tablero[DatosFila, DatosColumna].Color)
            {
                Console.WriteLine(Columna[i] + Fila[DatosFila] + " " + tablero[DatosFila, i].Tipo + " " + tablero[DatosFila, i].Color);
                break;
            }

            if (tablero[DatosFila, i] != null)
            {
                break;
            }

        }
    }

    public void MovimientoVerticalArriba() //Muestra los posibles movimientos velticalmente hacia arriba a los que la dama puede moverse
    {
        for (int i = DatosFila - 1; i >= 0; i--)
        {
            if (tablero[i, DatosColumna] == null)
            {
                Console.WriteLine(Columna[DatosColumna] + Fila[i] + " está vacía");
            }
            else if (tablero[i, DatosColumna].Color != tablero[DatosFila, DatosColumna].Color)
            {
                Console.WriteLine(Columna[DatosColumna] + Fila[i] + " " + tablero[i, DatosColumna].Tipo + " " + tablero[i, DatosColumna].Color);
                break;
            }
            else
            {
                break;
            }
        }
    }

    public void MovimientoVerticalAbajo() //Muestra los posibles movimientos velticalmente hacia abajo a los que la dama puede moverse
    {
        for (int i = DatosFila + 1; i < 8; i++)
        {
            if (tablero[DatosColumna, i] == null)
            {
                Console.WriteLine(Columna[DatosColumna] + Fila[i] + " está vacía");
            }
            else if (tablero[i, DatosColumna].Color != tablero[DatosFila, DatosColumna].Color)
            {
                Console.WriteLine(Columna[DatosColumna] + Fila[i] + " " + tablero[i, DatosColumna].Tipo + " " + tablero[i, DatosColumna].Color);
                break;
            }
            else
            {
                break;
            }
        }
    }

    public void MovimientoDiagonalIzquierdaArriba() //Muestra los posibles movimientos diagonales izquierdos hacia arriba a los que la dama puede moverse
    {
        int MoverFilas = DatosFila;
        int MoverColumna = DatosColumna;

        for (MoverFilas = MoverFilas - 1; MoverFilas > 0 && MoverColumna > 0; MoverFilas--)
        {
            MoverColumna--;
            if (tablero[MoverColumna, MoverFilas] == null)
            {
                Console.WriteLine(Columna[MoverColumna] + Fila[MoverFilas] + " está vacía");

            }
            else if (tablero[MoverFilas, MoverColumna].Color != tablero[MoverFilas, MoverColumna].Color)
            {
                Console.WriteLine(Columna[MoverColumna] + Fila[MoverFilas] + " " + tablero[MoverFilas, MoverColumna].Tipo + " " + tablero[MoverFilas, MoverColumna].Color);
                break;
            }
            else
            {
                break;
            }
        }
    }

    public void MovimientoDiagonalDerechaArriba() //Muestra los posibles movimientos diagonales derechos hacia arriba a los que la dama puede moverse
    {
        int MoverFilas = DatosFila;
        int MoverColumna = DatosColumna;

        for (MoverFilas = MoverFilas - 1; MoverFilas > 0 && MoverColumna < 8; MoverFilas--)
        {
            MoverColumna++;
            if (tablero[MoverColumna, MoverFilas] == null)
            {
                Console.WriteLine(Columna[MoverColumna] + Fila[MoverFilas] + " está vacía");

            }
            else if (tablero[MoverFilas, MoverColumna].Color != tablero[MoverFilas, MoverColumna].Color)
            {
                Console.WriteLine(Columna[MoverColumna] + Fila[MoverFilas] + " " + tablero[MoverFilas, MoverColumna].Tipo + " " + tablero[MoverFilas, MoverColumna].Color);
                break;
            }
            else
            {
                break;
            }
        }
    }

    public void MovimientoDiagonalDerechaAbajo() //Muestra los posibles movimientos diagonales derechos hacia abajo a los que la dama puede moverse
    {
        int MoverFilas = DatosFila;
        int MoverColumna = DatosColumna;

        for (MoverFilas = DatosFila + 1, MoverColumna = DatosColumna + 1; MoverFilas < 8 && MoverColumna < 8; MoverFilas++, MoverColumna++)
        {
            if (tablero[MoverFilas, MoverColumna] == null)
            {
                Console.WriteLine(Columna[MoverColumna] + Fila[MoverFilas] + " está vacía");
            }
            else if (tablero[MoverFilas, MoverColumna].Color != tablero[DatosFila, DatosColumna].Color)
            {
                Console.WriteLine(Columna[MoverColumna] + Fila[MoverFilas] + " " + tablero[MoverFilas, MoverColumna].Tipo + " " + tablero[MoverFilas, MoverColumna].Color);
                break;
            }
            else
            {
                break;
            }
        }
    }

    public void MovimientoDiagonalIzquierdaAbajo() //Muestra los posibles movimientos diagonlaes izquierdos hacia abajo a los que la dama puede moverse
    {
        int MoverFilas = DatosFila;
        int MoverColumna = DatosColumna;

        for (MoverFilas = DatosFila + 1, MoverColumna = DatosColumna - 1; MoverFilas < 8 && MoverColumna >= 0; MoverFilas++, MoverColumna--)
        {
            if (tablero[MoverFilas, MoverColumna] == null)
            {
                Console.WriteLine(Columna[MoverColumna] + Fila[MoverFilas] + " está vacía");
            }
            else if (tablero[MoverFilas, MoverColumna].Color != tablero[DatosFila, DatosColumna].Color)
            {
                Console.WriteLine(Columna[MoverColumna] + Fila[MoverFilas] + " " + tablero[MoverFilas, MoverColumna].Tipo + " " + tablero[MoverFilas, MoverColumna].Color);
                break;
            }
            else
            {
                break;
            }
        }
    }

    public Pieza[,] TableroEnvio ()
    {
        return tablero;
    }
}

