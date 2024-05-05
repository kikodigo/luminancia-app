using luminancia_app.Domain.Data;
using System.Xml;

namespace luminancia_app.Repository.Tabelas
{
    public class DadosTabelaLampada
    {
        public List<LampadasData> TabelaLampadaLed = new List<LampadasData>();
        public List<LampadasData> TabelaLampadaHalogeneo = new List<LampadasData>();
        public List<LampadasData> TabelaLampadaClassica = new List<LampadasData>();

        public DadosTabelaLampada()
        {
            ConstruirTabelaDeLampadas();
        }

        private void ConstruirTabelaDeLampadas()
        {
            TabelaLampadaLed.AddRange(new List<LampadasData>()
            {
                new()
                {
                    WattIndicado = 3,
                    MinLumens = 136
                },
                new()
                {
                    WattIndicado =5,
                    MinLumens = 249
                },
                new()
                {
                    WattIndicado = 5,
                    MinLumens = 470
                },
                new()
                {
                    WattIndicado = 8,
                    MinLumens = 806
                },
                new()
                {
                    WattIndicado = 12,
                    MinLumens = 1055
                },
                new()
                {
                    WattIndicado = 15,
                    MinLumens = 1521
                },
                new()
                {
                    WattIndicado = 24,
                    MinLumens = 2452
                }
            });

            TabelaLampadaHalogeneo.AddRange(new List<LampadasData>()
            {
                new()
                {
                    WattIndicado = 10,
                    MinLumens = 136
                },
                new()
                {
                    WattIndicado = 20,
                    MinLumens = 249
                },
                new()
                {
                    WattIndicado = 25,
                    MinLumens = 470
                },
                new()
                {
                    WattIndicado = 50,
                    MinLumens = 806
                },
                new()
                {
                    WattIndicado = 55,
                    MinLumens = 1055
                },
                new()
                {
                    WattIndicado = 70,
                    MinLumens = 1521
                },
                new()
                {
                    WattIndicado = 100,
                    MinLumens = 2452
                }
            });

            TabelaLampadaClassica.AddRange(new List<LampadasData>()
            {
                new()
                {
                    WattIndicado = 15,
                    MinLumens = 136
                },
                new()
                {
                    WattIndicado = 25,
                    MinLumens = 249
                },
                new()
                {
                    WattIndicado = 40,
                    MinLumens = 470
                },
                new()
                {
                    WattIndicado = 60,
                    MinLumens = 806
                },
                new()
                {
                    WattIndicado = 75,
                    MinLumens = 1055
                },
                new()
                {
                    WattIndicado = 100,
                    MinLumens = 1521
                },
                new()
                {
                    WattIndicado = 150,
                    MinLumens = 2452
                }
            });
        }

        public int PegarValorDeWattsLed(int lux)
        {
            int valorAtual = 0;
            foreach (var lampada in TabelaLampadaLed)
            {
                if (lux >= lampada.MinLumens)
                {
                    valorAtual = lampada.WattIndicado;
                }
            }

            if (valorAtual == 0)
                return TabelaLampadaLed.FirstOrDefault().WattIndicado;

            return valorAtual;
        }

        public int PegarValorDeWattsHalogeneo(int lux)
        {
            int valorAtual = 0;
            foreach (var lampada in TabelaLampadaHalogeneo)
            {
                if (lux >= lampada.MinLumens)
                {
                    valorAtual = lampada.WattIndicado;
                }
            }

            if (valorAtual == 0)
                return TabelaLampadaHalogeneo.FirstOrDefault().WattIndicado;

            return valorAtual;
        }

        public int PegarValorDeWattsClassica(int lux)
        {
            int valorAtual = 0;
            foreach (var lampada in TabelaLampadaClassica)
            {
                if (lux >= lampada.MinLumens)
                {
                    valorAtual = lampada.WattIndicado;
                }
            }

            if (valorAtual == 0)
                return TabelaLampadaClassica.FirstOrDefault().WattIndicado;

            return valorAtual;
        }
    }
}
