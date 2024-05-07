namespace luminancia_app.Core.Validacoes
{
    public static class ValidacoesDosCampos
    {
        public static (bool, string) ValidarComprimentoELargura(string comprimento, string largura)
        {
            bool hasError = false;
            string error = string.Empty;

            if (!int.TryParse(comprimento, out _))
            {
                error = "Comprimento não é um valor valido";
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
