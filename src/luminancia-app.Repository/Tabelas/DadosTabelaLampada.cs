using luminancia_app.Domain.TipoTabela;

namespace luminancia_app.Repository.Tabelas
{
    public class DadosTabelaLampada
    {
        public List<Lampadas> TabelaLampadas = new List<Lampadas>();

        public DadosTabelaLampada()
        {
            ConstruirTabelaLampada();
        }

        private void ConstruirTabelaLampada()
        {
            //TODO: Estruturar melhor essa tabela, pois não irá pegar todos os watts necessarios
            TabelaLampadas.AddRange(new List<Lampadas>()
            {
                new()
                {
                    NomeLampada = "Led",
                    WattIndicado = new List<int>() { 2,3 },
                    MinLumens = 136
                },
                new()
                {
                    NomeLampada = "Halogéneo",
                    WattIndicado = new List<int>() { 2,3 },
                    MinLumens = 136
                },
                new()
                {
                    NomeLampada = "Led",
                    WattIndicado = new List<int>() { 2,3 },
                    MinLumens = 136
                }

            });
        }
    }
}
