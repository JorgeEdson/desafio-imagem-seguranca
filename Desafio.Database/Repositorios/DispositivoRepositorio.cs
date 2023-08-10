using Desafio.Core.Dominio.Entidades;
using Desafio.Database.Repositorios.Base;

namespace Desafio.Database.Repositorios
{
    public class DispositivoRepositorio:BaseRepositorio<Dispositivo>
    {
        public DispositivoRepositorio(DesafioContext context):base(context)
        {
                
        }
    }
}
