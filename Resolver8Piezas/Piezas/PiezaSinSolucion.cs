

namespace Resolver8Piezas
{
    public class PiezaSinSolucion : IPiezaAjedrez
    {
        public string tipoDePieza = "PiezaSinSolucionx";
        public int n = 8;

        public bool EsSeguro(int fila, int columna, Estados[][] tablero)
        {

            for (int i = 0; i < fila; i++)
            {
                // Verificar si hay una reina en la misma columna
                if (tablero[i][columna] == Estados.Pieza)
                {
                    return false;
                }

                // Verificar diagonal superior izquierda
                if (columna - (fila - i) >= 0 && tablero[i][columna - (fila - i)] == Estados.Pieza)
                {
                    return false;
                }

                // Verificar diagonal superior derecha
                if (columna + (fila - i) < n && tablero[i][columna + (fila - i)] == Estados.Pieza)
                {
                    return false;
                }
                //movimiento del caballo
                if (tablero[fila][columna] != Estados.Pieza)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
