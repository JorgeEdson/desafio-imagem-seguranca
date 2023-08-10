using Desafio.Core.Dominio.Base;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;

namespace Desafio.Core.Dominio.Entidades
{
    [DataContract]
    public class Dispositivo : BaseEntidade
    {
        [DataMember]
        public string Nome { get; private set; }
        [DataMember]
        public int Endereco { get; private set; }
        public List<Evento> Eventos { get; private set; }

        public Dispositivo(string nome, int endereco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Endereco = endereco;
        }
        public Dispositivo()
        {
        }

        public void SetEventos(List<Evento> eventos) => Eventos = eventos;
    }
}
