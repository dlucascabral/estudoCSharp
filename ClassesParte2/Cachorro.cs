namespace ClassesParte2
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) : base(nome, idade)  
        {

        }

        public override Som SomEmitido => Som.Latido;
    }
}
//base(nome, idade) invoca o construtor da classe animal.