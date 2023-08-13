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
    [Table("Dispositivos")]
    public partial class Dispositivo : BaseEntidade
    {       

        [DataMember]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [DataMember]
        public int Endereco { get; set; }

        public virtual ICollection<Evento> Eventos { get; set; }

        public Dispositivo()
        {
            Eventos = new HashSet<Evento>();
        }
    }
}
