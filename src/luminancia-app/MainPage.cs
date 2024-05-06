using luminancia_app.Core.Servicos;
using luminancia_app.Core.Validacoes;
using luminancia_app.Domain.Response;
using luminancia_app.Repository.Tabelas;

namespace luminancia_app
{
    public partial class MainPage : Form
    {
        private readonly LuminanciaService _luminanciaService;
        public MainPage()
        {
            InitializeComponent();
            ConstruirCbx();
            _luminanciaService = new LuminanciaService();
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            var (haserror, error) = ValidacoesDosCampos.ValidarComprimentoELargura(Txt_Comprimento.Text, Txt_Largura.Text);

            if (haserror)
            {
                MessageBox.Show($"{error}",
                    "ERRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(Cbx_TipoAmbiente.Text))
            {
                MessageBox.Show($"Por favor, selecione um Ambiente a ser calculado",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            var valoresEmWatts = _luminanciaService.CalculadoraDeWatts(
                 int.Parse(Txt_Comprimento.Text),
                 int.Parse(Txt_Largura.Text),
                 Cbx_TipoAmbiente.Text);

            DefinirValoresNasTxtBox(valoresEmWatts);
        }

        private void DefinirValoresNasTxtBox(LuminanciaResponse valoresEmWatts)
        {
            var watts = " Watts";

            Txt_MinLed.Text = valoresEmWatts.LedWatt[0].ToString() + watts;
            Txt_MaxLed.Text = valoresEmWatts.LedWatt[1].ToString() + watts;

            Txt_MinHalo.Text = valoresEmWatts.HalogeneoWatt[0].ToString() + watts;
            Txt_MaxHalo.Text = valoresEmWatts.HalogeneoWatt[1].ToString() + watts;

            Txt_MinClass.Text = valoresEmWatts.ClassicaWatt[0].ToString() + watts;
            Txt_MaxClass.Text = valoresEmWatts.ClassicaWatt[1].ToString() + watts;
        }

        private void ConstruirCbx()
        {
            foreach (var item in new DadosTabelaAmbiente().TabelaAmbiente)
            {
                Cbx_TipoAmbiente.Items.Add(item.TipoAmbiente);
            }
        }
    }
}
