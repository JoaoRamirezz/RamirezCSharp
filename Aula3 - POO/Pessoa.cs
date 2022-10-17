public class Pessoa
{
    public Pessoa(string nome, string senha)
    {
        this.Nome = nome;
        this.senha = senha;
    }


    public string Nome {get; set;}
    public decimal Saldo {get; set;}
    public DateTime DataNascimento {get; set;}
    private string senha {get; set;}

    private long cpf;
    public string CPF
    {
        get
        {
            return cpf.ToString("000.000.000-00");
        }
        set
        {
            cpf = long.Parse(
                value.Replace(".","")
                .Replace("-", ""));
        }
    }

}