using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Desafio.WCF
{    
    [ServiceContract]
    public interface IDesafioService
    {
        [OperationContract]
        string AbrirFechar(int endereco);
        [OperationContract]
        string ManterAberto(int endereco);
        [OperationContract]
        string Fechar(int endereco);
    }
}
