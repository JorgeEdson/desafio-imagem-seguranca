using Desafio.Core.Dominio.Base;
using Desafio.Core.Dominio.Enuns;
using System.Runtime.Serialization;
using System;

namespace Desafio.Core.Dominio.Entidades
{
    [DataContract]
    public class Evento : BaseEntidade
    {
        [DataMember]
        public Guid DispositivoId { get; private set; }        
        public Dispositivo Dispositivo { get; private set; }
        [DataMember]
        public TipoEvento TipoEvento { get; private set; }

        public Evento(Dispositivo dispositivo, TipoEvento tipoEvento)
        {
            DispositivoId = dispositivo.Id;
            Dispositivo = dispositivo;
            TipoEvento = tipoEvento;
        }
        public Evento()
        {                
        }
    }
}
