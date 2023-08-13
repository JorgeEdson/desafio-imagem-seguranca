namespace Desafio.WCF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Eventos")]
    public partial class Evento
    {
        [DataMember]
        [Key]
        public Guid Id { get; set; }

        [DataMember]
        [Required]
        public TipoEvento TipoEvento { get; set; }

        [DataMember]        
        [Required]        
        public Guid DispositivoId { get; set; }

        [DataMember]
        [ForeignKey("DispositivoId")]
        public virtual Dispositivo Dispositivo { get; set; }
        public Evento(Dispositivo dispositivo, TipoEvento tipoEvento)
        {
            Id = Guid.NewGuid();
            DispositivoId = dispositivo.Id;
            Dispositivo = dispositivo;
            TipoEvento = tipoEvento;
        }
    }
}
