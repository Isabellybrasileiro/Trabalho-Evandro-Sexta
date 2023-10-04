namespace Api_Funcionario.Models;

public class Gerente
{
    private string _nome;
    private int _nivel;
    private string _departamento;

    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }

    public int Nivel
    {
        get => _nivel;
        set => _nivel = value;
    }

    public string Departamento
    {
        get => _departamento;
        set => _departamento = value;
    }

    public Gerente()
    {
        _nome = string.Empty;
        _nivel= 0;
        _departamento = string.Empty;
    }

    public Gerente(string nome, int nivel, string departamento)
    {
        _nome = nome;
        _nivel= nivel;
        _departamento = departamento;
    }
}