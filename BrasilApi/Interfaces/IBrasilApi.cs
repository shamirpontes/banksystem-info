using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrasilApi.View
{
    public interface IBrasilApi
    {
        Task<ReponseGenerico<EnderecoModel>> BuscasEnderecoPorCEP(string cep)

        Task<ReponseGenerico<List<BancoModel>>> BuscarTodosBancos();

        Task<ReponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);

    }
}