using PROYECTO__AJEDREZ_;

Tablero objTablero = new Tablero();
Pieza[,] tablero = new Pieza[8, 8];  //Crea una matriz para representa el tablero

Console.WriteLine("¡Bienvenido a este juego de Ajedrez 🏁!");
Console.WriteLine("La finalidad de este juego es solo mostrar los posibles movimietos y casillas a las que la dama es capaz de moverse.");
Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine("Ingresar la cantidad de piezas que desea agregar al tablero:");
Console.WriteLine("-----------------------------------------------------------------");
int CantPieza = int.Parse(Console.ReadLine());
for (int i = 0; i < CantPieza; i++)
{
   objTablero.GuardarDatosPieza();  //Llama al método para guardar los datos de cada pieza

}

//Se llama a todos los métodos para mostrar los posibles movimientos de la dama
objTablero.GuardarDatosDama();
objTablero.MovimientoHorizontalDerecha();
objTablero.MovimientoHorizontalIzquieda();
objTablero.MovimientoVerticalArriba();
objTablero.MovimientoVerticalAbajo();
objTablero.MovimientoDiagonalIzquierdaArriba();
objTablero.MovimientoDiagonalDerechaArriba();
objTablero.MovimientoDiagonalDerechaAbajo();
objTablero.MovimientoDiagonalIzquierdaAbajo();

tablero = objTablero.TableroEnvio(); //Se obtiene el tablero después de agregar las piezas y dama
ImprimirTablero(tablero); //Llama al método para imprimir el tablero

static void ImprimirTablero(Pieza[,] tablero)  //Método para imprimir el tablero 
{
   Console.WriteLine("------------------------------------------");
   Console.WriteLine("El tablero 🏁 se mostrará a continuación");
   Console.WriteLine("------------------------------------------");
   Console.WriteLine("En este tablero se mostrará solo la inicial del tipo de pieza y la inicial del color de dicha pieza");

   Console.WriteLine("  -------------------------");
   for (int fila = 0; fila < 8; fila++)
   {
      Console.Write((8 - fila) + "|");
      for (int columna = 0; columna < 8; columna++)
      {
         if (tablero[fila, columna] == null)
         {
            Console.Write(" - "); //Si no hay un pieza se imprime un guión en el tablero
         }
         else
         {
            char tipo = tablero[fila, columna].Tipo[0];
            char color = tablero[fila, columna].Color[0];
            Console.Write($" {tipo}{color}");
         }
      }
      Console.WriteLine("|");
   }

   Console.WriteLine("  -------------------------");
   Console.WriteLine("   a  b  c  d  e  f  g  h");
}




