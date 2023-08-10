using Desafio.Core.Dominio.Entidades;
using System.ServiceModel;

namespace Desafio.WCF
{    
    [ServiceContract]
    public interface IDesafioService
    {
        [OperationContract]
        string AbrirFechar(Evento evento);
        [OperationContract]
        string ManterAberto(Evento evento);
        [OperationContract]
        string Fechar(Evento evento);
    }
}
