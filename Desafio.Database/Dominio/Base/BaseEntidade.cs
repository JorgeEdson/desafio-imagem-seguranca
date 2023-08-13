using System;
using System.Runtime.Serialization;

namespace Desafio.Core.Dominio.Base
{
    [DataContract]
    public abstract class BaseEntidade
    {
        [DataMember]
        public Guid Id { get; set; }
    }
}
