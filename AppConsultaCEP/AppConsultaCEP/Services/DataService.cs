using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppConsultaCEP.Model;

namespace AppConsultaCEP.Services
{
    internal class DataService
    {
        public static async Task<CEP> getInfoFromCEP(string cep)
        {
            string urlApi = "https://cep.metoda.com.br/endereco/by-cep?cep=" + cep;

            dynamic resultado = await getDataFromService(urlApi).ConfigureAwait(false);

            if (resultado != null)
            {
                CEP info_cep = new CEP();

                info_cep.cep = (string)resultado.CEP;
                info_cep.id_logradouro = (string)resultado.id_logradouro;
                info_cep.tipo = (string)resultado.tipo;
                info_cep.descricao = (string)resultado.descricao;
                info_cep.id_cidade = (string)resultado.id_cidade;
                info_cep.UF = (string)resultado.UF;
                info_cep.complemento = (string)resultado.complemento;
                info_cep.descricao_cidade = (string)resultado.descricao_cidade;
                info_cep.codigo_cidade_ibge = (string)resultado.codigo_cidade_ibge;
                info_cep.descricao_bairro = (string)resultado.descricao_bairro;

                return info_cep;
            }
            else
            {
                return null;
            }
        }

        public static async Task<Logradouro> getInfoFromLogradouro(string logradouro)
        {
            string urlApi = "https://cep.metoda.com.br/cep/by-logradouro?logradouro=" + logradouro;

            dynamic resultado = await getDataFromService(urlApi).ConfigureAwait(false);

            if (resultado != null)
            {
                Logradouro info_logradouro = new Logradouro();

                info_logradouro.CEP = (string)resultado[0].CEP;
                info_logradouro.id_logradouro = (string)resultado[0].id_logradouro;
                info_logradouro.tipo = (string)resultado[0].tipo;
                info_logradouro.descricao = (string)resultado[0].descricao;
                info_logradouro.id_cidade = (string)resultado[0].id_cidade;
                info_logradouro.UF = (string)resultado[0].UF;
                info_logradouro.complemento = (string)resultado[0].complemento;
                info_logradouro.descricao_cidade = (string)resultado[0].descricao_cidade;
                info_logradouro.codigo_cidade_ibge = (string)resultado[0].codigo_cidade_ibge;
                info_logradouro.descricao_bairro = (string)resultado[0].descricao_bairro;

                return info_logradouro;
            }
            else
            {
                return null;
            }
        }

        public static async Task<dynamic> getDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);

            dynamic data = null;
            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }
            return data;
        }
    }
}