namespace Model
{
    public class Pessoa
    {
        public string? Nome { get; set; }

        private int _idade;
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                    throw new ArgumentException("A idade não pode ser menor que zero");

                _idade = value;
            }
        }

        public string? Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}