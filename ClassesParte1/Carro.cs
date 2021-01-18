namespace ClassesParte1
{
    public class Carro
    {
        //Atributos do carro
        public Cor Cor { get; set;}
        public int Portas;
        public string Modelo { get; } //Propriedade: só é possível visualizar esse atributo depois de criado o objeto (somente leitura)
        private bool ligado = false;

        public bool Ligado { //Propriedade: define umamaneira de acessr atributos
            get {
                return ligado;
            }
            set {

            }
        }

        //Comportamento do carro
        
        public Carro(Cor cor, int portas, string modelo) {
            Cor = cor;
            Portas = portas;
            Modelo = modelo;
        }
        public string ligar() {
            ligado = true;
            return "O carro foi ligado";
        }

        public string desligar() {
            ligado = false;
            return "O carro foi desligado";
        }

        public string andar() {
            if (ligado == true)
            {
               return "O carro está andando"; 
            }
            return "Ligue o carro primeiro";
        }
    }
}