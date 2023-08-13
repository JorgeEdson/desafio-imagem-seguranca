namespace Desafio.WCF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
       using System.Runtime.Serialization;

    [DataContract]
    [Table("Dispositivos")]
    public partial class Dispositivo
    {
        [DataMember]
        [Key]
        public Guid Id { get; set; }

        [DataMember]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [DataMember]
        [Required]
        public int Endereco { get; set; }
        
        [DataMember]
        public virtual List<Evento> Eventos { get; set; }

        public Dispositivo()
        {
            Eventos = new List<Evento>();
        }
    }
}
