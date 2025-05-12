using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ConsultaCnpj.Services
{
    //Classe responsável por realziar consultas de CNPJ a API pública da ReceitaWS
    public class CnpjService
    {
        //Objeto JObject contendo os dados retornados pela API
        public async Task<JObject> ConsultarCnpjAsync(string cnpj)
        {
            using (var client = new HttpClient())
            {
                // Monta a URL da API com o CNPJ informado
                string url = $"https://www.receitaws.com.br/v1/cnpj/{cnpj}";

                //Realiza a chamada HTTP GET
                var response = await client.GetAsync(url);

                // verifica se a resposta foi bem sucedida (código 200)
                if (response.IsSuccessStatusCode)
                {
                    //Lê o conteúdo da responsta como string JSON
                    string json = await response.Content.ReadAsStringAsync();

                    //Converte a string JSON para um objeto JObject
                    return JObject.Parse(json);
                }
                else
                {
                    throw new Exception("Erro ao consultar CNPJ");
                }
            }
        }
    }
}
