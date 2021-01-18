namespace Interfaces
{
    public class Copiadora : ICopiadora
    {
        public string Copiar(string texto) {
            return $"Texto a ser copiado: {texto}";
        }
    }
}