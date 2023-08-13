namespace Desafio.WebApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;    

    [Table("Dispositivos")]
    public partial class Dispositivo
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public int Endereco { get; set; }
        
        public virtual List<Evento> Eventos { get; set; }

        public Dispositivo(string nome, int endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Eventos = new List<Evento>();
        }

        Dispositivo() { }
    }
}
