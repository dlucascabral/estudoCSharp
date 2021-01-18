namespace ClassesParte2
{
    public abstract class Animal //Uma classe abstrata não pode ser instanciada, assim não posso criar um animal, somente gatos ou cachorros
    {
        public string Nome { get;}
        public int Idade { get; }

        public abstract Som SomEmitido { get; } //Essa propriedade deverá ser implementada por cada classe filha já que é abstrata

        public virtual string Locomocao { get {return "Está andando";} } // Essa propriedade poderá ou não ser sobreescrita

        public Animal(string nome, int idade) //Outra forma de impedir a criação de um animal é tornando o construtor privado
        {
            Nome = nome;
            Idade = idade;
        }
    }
}