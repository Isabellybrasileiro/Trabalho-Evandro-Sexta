namespace Api_Funcionario.Models
{
    internal class Diretor : Gerente
    {
        private string _area_atuacao;

        public string Area_atuacao
        {
            get => _area_atuacao;
            set => _area_atuacao = value;
        }

        public Diretor()
        {
            _area_atuacao = string.Empty;
        }

        public Diretor(
            string nome,
            int nivel,
            string departamento,
            string area_atuacao) :
            base (nome, nivel, departamento)
            {
                _area_atuacao = area_atuacao;
            }
    }


}