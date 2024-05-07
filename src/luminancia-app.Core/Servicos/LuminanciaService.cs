using luminancia_app.Domain.Response;
using luminancia_app.Repository.Tabelas;

namespace luminancia_app.Core.Servicos
{
    public class LuminanciaService
    {
        private readonly DadosTabelaAmbiente _dadosTabelaAmbiente;
        private readonly DadosTabelaLampada _dadosTabelaLampada;

        public LuminanciaService()
        {
            _dadosTabelaAmbiente = new DadosTabelaAmbiente();
            _dadosTabelaLampada = new DadosTabelaLampada();
        }

        public LuminanciaResponse CalculadoraDeWatts(int comprimento, int largura, string tipoAmbiente)
        {
            var dadosAmbiente = _dadosTabelaAmbiente.PegarValorMinimoDeLumens(tipoAmbiente);

            var luxMin = (comprimento * largura) * dadosAmbiente.LumensMin;
            var luxMax = (comprimento * largura) * dadosAmbiente.LumensMax;

            var minWattLed = _dadosTabelaLampada.PegarValorDeWattsLed(luxMin);
            var maxWattLed = _dadosTabelaLampada.PegarValorDeWattsLed(luxMax);

            var minWattHalogeneo = _dadosTabelaLampada.PegarValorDeWattsHalogeneo(luxMin);
            var maxWattHalogeneo = _dadosTabelaLampada.PegarValorDeWattsHalogeneo(luxMax);

            var minWattClassica = _dadosTabelaLampada.PegarValorDeWattsClassica(luxMin);
            var maxWattClassica = _dadosTabelaLampada.PegarValorDeWattsClassica(luxMax);

            return new LuminanciaResponse()
            {
                LedWatt = new List<int>()
                {
                    minWattLed,
                    maxWattLed
                },
                HalogeneoWatt = new List<int>()
                {
                    minWattHalogeneo,
                    maxWattHalogeneo},
                ClassicaWatt = new List<int>()
                {
                    minWattClassica,
                    maxWattClassica
                }
            };
        }
    }
}
