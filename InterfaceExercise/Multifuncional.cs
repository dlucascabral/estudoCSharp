namespace InterfaceExercise
{
    public class Multifuncional : ICopiadora, IEscaneadora, IImpressora
    {
        public string Copiar(string texto) {
            return texto;
        }
        public string Escanear(string texto) {
            return texto;
        }
        public string Imprimir(string texto) {
            return texto;
        }
    }
}