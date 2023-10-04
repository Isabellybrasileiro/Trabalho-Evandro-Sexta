namespace Api_Funcionario.Models
{
    internal class FuncionarioRH : Funcionario
    {
        private int _matricula;

        public int Matricula
        {
            get => _matricula;
            set => _matricula = value;
        }

        public FuncionarioRH()
        {
            _matricula = 0;
        }

        public FuncionarioRH(
            string nome,
            string cpf,
            string cargo,
            int idade,
            int matricula) :
            base (nome, cpf, cargo, idade)
            {
                _matricula = matricula;
            }
    }


}