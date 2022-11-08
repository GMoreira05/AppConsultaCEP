using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsultaCEP.Model
{
    class Logradouro
    {
        public string CEP { get; set; }
        public string id_logradouro { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public string id_cidade { get; set; }
        public string UF { get; set; }
        public string complemento { get; set; }
        public string descricao_cidade { get; set; }
        public string codigo_cidade_ibge { get; set; }
        public string descricao_bairro { get; set; }

        public Logradouro()
        {
            this.CEP = "";
            this.id_logradouro = "";
            this.tipo = "";
            this.descricao = "";
            this.id_cidade = "";
            this.UF = "";
            this.complemento = "";
            this.descricao_cidade = "";
            this.codigo_cidade_ibge = "";
            this.descricao_bairro = "";
        }
    }
}
