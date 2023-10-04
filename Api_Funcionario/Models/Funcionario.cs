namespace Api_Funcionario.Models;

public class Funcionario
{
    private string _nome;
    private string _cpf;
    private string _cargo;
    private int _idade;

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    public string Cpf
    {
        get => _cpf;
        set => _cpf = value;
    }

    public string Cargo
    {
        get => _cargo;
        set => _cargo = value;
    }

    public int Idade
    {
        get => _idade;
        set => _idade = value;
    }

    public Funcionario()
    {
        _nome = string.Empty;
        _cpf = string.Empty;
        _cargo = string.Empty;
        _idade = 0;
    }

    public Funcionario(string nome, string cpf, string cargo, int idade)
    {
        _nome = nome;
        _cpf = cpf;
        _cargo = cargo;
        _idade = idade;
    }
}