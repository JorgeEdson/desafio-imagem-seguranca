using Desafio.Core.Dominio.Entidades;
using Desafio.Database.Repositorios.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Database.Repositorios
{
    public class EventoRepositorio : BaseRepositorio<Evento>
    {
        public EventoRepositorio(DesafioContext context) : base(context)
        {
                
        }
    }
}
