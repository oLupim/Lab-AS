
public abstract class Funcionario
{
    //atributos
    public string nome;
    public int matricula;

    public List<string>Projetos = new List<string>(); //lista de string para Projetos.

    public Funcionario(string nome, int matricula) //metodo construtor
    {
        this.nome = nome;
        this.matricula = matricula;
    }

    public abstract double CalcularSalario(); //métodos abstratos
    public abstract void ExibirInformacoes(); //métodos abstratos

    public void AdicionarProjeto(string projeto) //armazena o nome do projeto em uma lista de strings.
    {
        Projetos.Add(projeto);
    }

    public void AdicionarProjeto(List<string> Lista) //armazena cada nome de projeto da lista em uma lista de strings.
    {
        foreach (string projeto in Projetos){Lista.Add(projeto);} //se tiver string na lista Projetos, irá add essa string na lista
    }
}