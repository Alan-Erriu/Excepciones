using Resolver8Piezas;


Reina reina = new Reina();
Torre torre = new Torre();
Alfil alfil = new Alfil();
Peon peon = new Peon();
PiezaSinSolucion piezax = new PiezaSinSolucion();


Resolver tablero = new Resolver(piezax);
try
{
    if (tablero.Resolver2())
    {
        Console.WriteLine("Solución encontrada para tipo de pieza: " + piezax.tipoDePieza);
        Console.WriteLine("");
        tablero.ImprimirTablero();
    }
    else
    {
        Console.WriteLine("No se encontró una solución.");
    }
}
catch (SinSolucionException e)
{
    Console.WriteLine($"Manejando excepciones desde el program:  {e.Message}");
    Console.WriteLine("ubicacion del error:");
    Console.WriteLine(e.StackTrace);

}

