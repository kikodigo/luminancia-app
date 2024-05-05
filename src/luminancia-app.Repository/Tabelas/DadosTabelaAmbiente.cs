using luminancia_app.Domain.Data;

namespace luminancia_app.Repository.Tabelas
{
    public class DadosTabelaAmbiente
    {
        public List<AmbienteData> TabelaAmbiente = new List<AmbienteData>();

        public DadosTabelaAmbiente()
        {
            ConstruirTabelaAmbiente();
        }

        private void ConstruirTabelaAmbiente()
        {
            TabelaAmbiente.AddRange(new List<AmbienteData>()
            {
                new ()
                {
                    TipoAmbiente = "Sala - Luz Geral",
                    LumensMin = 100,
                    LumensMax = 200
                },
                new ()
                {
                    TipoAmbiente = "Sala - Luz Local (Leitura,Costura)",
                    LumensMin = 300,
                    LumensMax = 750
                },
                new ()
                {
                    TipoAmbiente = "Cozinha - Luz Geral",
                    LumensMin = 100,
                    LumensMax = 200
                },
                new ()
                {
                    TipoAmbiente = "Cozinha Luz Local (Fogão, Pia, Mesa)",
                    LumensMin = 200,
                    LumensMax = 500
                },
                new ()
                {
                    TipoAmbiente = "Quarto - Luz Geral",
                    LumensMin = 100,
                    LumensMax = 200
                },
                new ()
                {
                    TipoAmbiente = "Quarto - Luz Local (Cabeceira)",
                    LumensMin = 200,
                    LumensMax = 500
                },
                new ()
                {
                    TipoAmbiente = "Banheiro - Luz Geral",
                    LumensMin = 100,
                    LumensMax = 200
                },
                new ()
                {
                    TipoAmbiente = "Banheiro - Luz Local (Espelho)",
                    LumensMin = 200,
                    LumensMax = 500
                },
                new ()
                {
                    TipoAmbiente = "Hall, Escada, Despensa, Garagem",
                    LumensMin = 75,
                    LumensMax = 150
                },
                new ()
                {
                    TipoAmbiente = "Escritório - Mesa de Trabalho",
                    LumensMin = 300,
                    LumensMax = 500
                }
            });
        }

        public AmbienteData PegarValorMinimoDeLumens(string tipoAmbiente)
        {
            return TabelaAmbiente.FirstOrDefault(x => x.TipoAmbiente == tipoAmbiente);
        }
    }
}
