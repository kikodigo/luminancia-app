using luminancia_app.Core.Servicos;
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
           var valoresEmWatts = _luminanciaService.CalculadoraDeWatts(
                int.Parse(Txt_Altura.Text),
                int.Parse(Txt_Largura.Text),
                Cbx_TipoAmbiente.Text);

            MessageBox.Show(
                $"Min Led: {valoresEmWatts.LedWatt[0]} \n" +
                $"Max led: {valoresEmWatts.LedWatt[1]} \n" +
                $"Min Halo: {valoresEmWatts.HalogeneoWatt[0]} \n" +
                $"Max Halo:  {valoresEmWatts.HalogeneoWatt[1]} \n" +
                $"Min Class:  {valoresEmWatts.ClassicaWatt[0]}\n" +
                $"Max Class:  {valoresEmWatts.ClassicaWatt[1]}");
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
