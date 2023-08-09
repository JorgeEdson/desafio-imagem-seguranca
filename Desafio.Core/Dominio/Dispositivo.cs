using Desafio.Core.Dominio.Base;

namespace Desafio.Core.Dominio
{
    public class Dispositivo : BaseEntidade
    {
        public string Nome { get; private set; }
        public int Endereco { get; private set; }

        public Dispositivo(string nome, int endereco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Endereco = endereco;
        }
    }
}
