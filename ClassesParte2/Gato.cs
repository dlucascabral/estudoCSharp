namespace ClassesParte2
{
    public class Gato : Animal
    {
       public Gato(string nome, int idade) : base(nome, idade)
       {

       }

        public override Som SomEmitido => Som.Miado;

        public override string Locomocao => "Está pulando";
    }
}