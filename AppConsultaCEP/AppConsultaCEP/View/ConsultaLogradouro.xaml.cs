using AppConsultaCEP.Model;
using AppConsultaCEP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppConsultaCEP.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaLogradouro : ContentPage
    {
        public ConsultaLogradouro()
        {
            InitializeComponent();
        }

        private async void btn_Buscar_Clicked(object sender, EventArgs e)
        {
            try
            {
                btn_Buscar.Text = "Carregando...";
                btn_Buscar.IsEnabled = false;

                Logradouro consulta = await DataService.getInfoFromLogradouro(txt_Logradouro.Text);

                lbl_Logradouro.Text += txt_Logradouro.Text;
                lbl_CEP.Text += consulta.CEP;
                lbl_descricao_bairro.Text += consulta.descricao_bairro;
                lbl_descricao_cidade.Text += consulta.descricao_cidade;
                lbl_tipo.Text += consulta.tipo;
                lbl_codigo_cidade_ibge.Text += consulta.codigo_cidade_ibge;
                lbl_id_cidade.Text += consulta.id_cidade;
                lbl_uf.Text += consulta.UF;

                btn_Buscar.Text = "Nova Consulta";
                btn_Buscar.IsEnabled = true;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}