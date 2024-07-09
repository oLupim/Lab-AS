public class Empresa
{

    public List<Funcionario>ListaFuncionarios = new List<Funcionario>();

    public void AdicionarFuncionario(Funcionario Funcionario)
    {
        ListaFuncionarios.Add(Funcionario);
    }

    public void RemoverFuncionario(int NumeroMatricula)
    {
        
        for (int i = 0; i < ListaFuncionarios.Count; i++)
        {

            if (ListaFuncionarios[i].matricula == NumeroMatricula)
            {
                ListaFuncionarios.RemoveAt(i);
            }
        }
    }

    public void ExibirFuncionarios()
    {
        for (int i = 0; i < ListaFuncionarios.Count; i++)
        {
            ListaFuncionarios[i].ExibirInformacoes();

            if (ListaFuncionarios[i].Projetos.Count > 0)
            {
                Console.WriteLine($"Projetos: {string.Join(", ", ListaFuncionarios[i].Projetos)}");
            }

            else
            {
                Console.WriteLine("Projetos: Nenhum Projeto");
            }
            Console.WriteLine();
        }
    }
}
