namespace Desafio.Database.Dominio
{
    using Desafio.Core.Dominio.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Eventos")]
    public partial class Evento : BaseEntidade
    {
        [DataMember]
        public Guid DispositivoId { get; set; }

        [DataMember]
        public int TipoEvento { get; set; }

        public virtual Dispositivo Dispositivo { get; set; }
    }
}
