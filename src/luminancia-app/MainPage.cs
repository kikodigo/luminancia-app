using luminancia_app.Repository.Tabelas;
using System.Net.Http.Headers;

namespace luminancia_app
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            ConstruirCbx();
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
          

        }      


        private void ConstruirCbx()
        {
            var dadosTabelaAmbiente = new DadosTabelaAmbiente();

            foreach (var item in dadosTabelaAmbiente.TabelaAmbiente)
            {
                Cbx_TipoAmbiente.Items.Add(item.TipoAmbiente);
            }
        }
    }
}
