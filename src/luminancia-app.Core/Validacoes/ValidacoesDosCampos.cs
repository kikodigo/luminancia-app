namespace luminancia_app.Core.Validacoes
{
    public static class ValidacoesDosCampos
    {
        public static (bool, string) ValidarAlturaELargura(string altura, string largura)
        {
            bool hasError = false;
            string error = string.Empty;

            if (!int.TryParse(altura, out _))
            {
                error = "Altura não é um valor valido";
                hasError = true;
            }

            if (!int.TryParse(largura, out _))
            {
                error = hasError ? error + "- Largura não é um valor valido" : "Largura não é um valor valido";
                hasError = true;
            }

            return (hasError, error);
        }
    }
}
