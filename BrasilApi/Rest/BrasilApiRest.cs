using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.BrasilApi.Dtos;
using System.BrasilApi.Interfaces;
using System.BrasilApi.Models;
using System.Text.Json;
using System.Dynamic;

namespace BrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public Task<ReponseGenerico<EnderecoModel>> BuscasEnderecoPorCEP(string cep)
        {
            var request = new HTTpRequestMessage(HttpMethod.get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new ReponseGenerico<EnderecoModel>();
            
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerialize.Deseralize<EnderecoModel>(contentResp);

                if (ReponseGenerico.IsSucessStatusCode)
                {
                   response.CodigoHttp = responseBrasilApi.StatusCode;
                   response.DadosRetorno = objResponse;
                }
                else {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerialize.Deseralize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }

        public Task<ReponseGenerico<List<BancoModel>>> BuscarTodosBancos()
        {

        }

        public Task<ReponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {

        }
    }
}