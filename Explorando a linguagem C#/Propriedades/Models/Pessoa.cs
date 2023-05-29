using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome
			{
            get => _nome; // body expression serve para retornar uma única linha de código (não precisa de return)

            set
				{
					if (value == "")
						throw new ArgumentException("O nome não pode ser vazio");
					
					_nome = value;
				}
			}

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

		public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar()
		{
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}