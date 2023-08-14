namespace Desafio.WebApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Eventos")]
    public partial class Evento
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid DispositivoId { get; set; }

        public TipoEvento TipoEvento { get; set; }

        [ForeignKey("DispositivoId")]
        public virtual Dispositivo Dispositivo { get; set; }

        public Evento(Dispositivo dispositivo, TipoEvento tipoEvento)
        {
            Id = Guid.NewGuid();
            DispositivoId = dispositivo.Id;
            Dispositivo = dispositivo;
            TipoEvento = tipoEvento;
        }

        public Evento()
        {                
        }
    }
}
