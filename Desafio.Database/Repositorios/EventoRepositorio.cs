using Desafio.Database.Dominio;
using Desafio.Database.Repositorios.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Database.Repositorios
{
    public class EventoRepositorio : BaseRepositorio<Evento>
    {
        public EventoRepositorio(DesafioContext2 context) : base(context)
        {
                
        }
    }
}
