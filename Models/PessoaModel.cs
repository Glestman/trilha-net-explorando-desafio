namespace DesafioProjetoHospedagem.Models;

public class PessoaModel
{
    public PessoaModel() { }

    public PessoaModel(string nome)
    {
        Nome = nome;
    }

    public PessoaModel(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}