namespace Api_Funcionario.Models
{
    internal class Dados : Funcionario
    {
        private string _escolaridade;
        private string _especializacao;

        public string Escolaridade
        {
            get => _escolaridade;
            set => _escolaridade = value;
        }

        public string Especializacao
        {
            get => _especializacao;
            set => _especializacao = value;
        }

        public Dados()
        {
            _escolaridade = string.Empty;
            _especializacao = string.Empty;
        }

        public Dados(
            string nome,
            string cpf,
            string cargo,
            int idade,
            string escolaridade,
            string especializacao) :
            base (nome, cpf, cargo, idade)
            {
                _escolaridade = escolaridade;
                _especializacao = escolaridade;
            }
    }


}