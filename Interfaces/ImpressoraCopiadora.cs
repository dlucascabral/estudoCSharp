namespace Interfaces
{
    public class ImpressoraCopiadora : IImpressora, ICopiadora
    {
        public string Imprimir(string texto) {
            return $"Texto a imprimir: {texto}";
        }

        public string Copiar(string texto) {
            return $"Texto a ser copiado: {texto}";
        }
    }
}