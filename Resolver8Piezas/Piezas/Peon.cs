﻿

namespace Resolver8Piezas
{
    public class Peon : IPiezaAjedrez
    {
        public int n = 8;
        public string tipoDePieza = "Peon";

        public bool EsSeguro(int fila, int columna, Estados[][] tablero)
        {

            for (int i = 0; i < fila; i++)
            {
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
            }
            return true;
        }
    }
}