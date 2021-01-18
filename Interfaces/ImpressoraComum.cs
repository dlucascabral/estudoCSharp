namespace Interfaces
{
    public class ImpressoraComum : IImpressora
    {
        public string Imprimir(string texto) {
            return $"Texto a imprimir: {texto}";
        }
    }
}