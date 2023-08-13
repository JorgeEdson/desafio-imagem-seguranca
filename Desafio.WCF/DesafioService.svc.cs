using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.WCF
{
    public class DesafioService : IDesafioService
    {          
        public string AbrirFechar(int endereco)
        {
            using (var _context = new WcfContext()) 
            { 
                var dispositivo = _context.ObterDispositivoPorEndereco(endereco);
                var evento = new Evento(dispositivo,TipoEvento.AbrirFechar);
                _context.Eventos.Add(evento);
                _context.SaveChanges();
                return "O dispositivo "+dispositivo.Nome+" foi acionado para Abrir e Fechar";
            }
        }

        public string Fechar(int endereco)
        {
            using (var _context = new WcfContext())
            {
                var dispositivo = _context.ObterDispositivoPorEndereco(endereco);
                var evento = new Evento(dispositivo, TipoEvento.Fechar);
                _context.Eventos.Add(evento);
                _context.SaveChanges();
                return "O dispositivo " + dispositivo.Nome + " foi acionado para Fechar";
            }
        }
        

        public string ManterAberto(int endereco)
        {
            using (var _context = new WcfContext())
            {
                var dispositivo = _context.ObterDispositivoPorEndereco(endereco);
                var evento = new Evento(dispositivo, TipoEvento.ManterAberto);
                _context.Eventos.Add(evento);
                _context.SaveChanges();
                return "O dispositivo " + dispositivo.Nome + " foi acionado para Manter Aberto";
            }
        }
    }
}
