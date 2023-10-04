namespace Api_Funcionario.Models
{
    internal class FuncionarioADM : Funcionario
    {
        private int _contaBancaria;

        public int ContaBancaria
        {
            get => _contaBancaria;
            set => _contaBancaria = value;
        }

        public FuncionarioADM()
        {
            _contaBancaria = 0;
        }

        public FuncionarioADM(
            string nome,
            string cpf,
            string cargo,
            int idade,
            int contaBancaria) :
            base (nome, cpf, cargo, idade)
            {
                _contaBancaria = contaBancaria;
            }
    }


}