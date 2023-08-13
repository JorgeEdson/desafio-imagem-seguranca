using Desafio.Database.Dominio;
using Desafio.Database.Repositorios.Base;

namespace Desafio.Database.Repositorios
{
    public class DispositivoRepositorio:BaseRepositorio<Dispositivo>
    {
        public DispositivoRepositorio(DesafioContext2 context):base(context)
        {
                
        }
    }
}
