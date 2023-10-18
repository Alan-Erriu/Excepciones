

namespace Resolver8Piezas
{
    public class SinSolucionException : Exception
    {
         public SinSolucionException() : base("No se puede cocolocar 8 de estas piezas") { }
        
    }
}
